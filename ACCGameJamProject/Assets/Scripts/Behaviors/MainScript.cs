using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public Transform canvasTransform;
    private void Awake() {
        AssetSource.Init();
        LanguageAsset.Init();
        MenuScript.Init(canvasTransform, AssetSource.Menus.mainMenu);
    }
}
