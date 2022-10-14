 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MenuScript : MonoBehaviour
{
    public static Transform canvasTransform;
    public static MenuScript currentMenu;
    public static void Init(Transform canvasTransform, GameObject firstMenuGameObject){
        MenuScript.canvasTransform = canvasTransform;
        ChangeMenu(firstMenuGameObject);
    }
    public static async void ChangeMenu(GameObject menuGameObject, TransitionType transitionType = TransitionType.Instant){
        if (canvasTransform == null){
            Debug.LogError("Not initted");
        }
        switch(transitionType){
            default:
                if (currentMenu != null)
                    GameObject.Destroy(currentMenu.gameObject);
                
            break;
        }
        currentMenu = GameObject.Instantiate(menuGameObject, canvasTransform).GetComponent<MenuScript>();
        currentMenu.OnCreated();
        switch(transitionType){
            default:
                currentMenu.Appear();
            break;
        }
    }  
    public CanvasGroup canvasGroup;
    private void Awake() {
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null){
            throw new System.Exception("No canvas");
        }
        canvasGroup.alpha = 0;
    }
    public async void Appear(float time = 0){
        if (time == 0){
            canvasGroup.alpha = 1;
            return;
        }
    }
    public async void Disappear(float time = 0){
        if (time == 0){
            canvasGroup.alpha = 0;
            return;
        }
    }
    public abstract void OnCreated();
}

public enum TransitionType{
    Instant,
    FadeInSlow,
    FadeInFast,
}
