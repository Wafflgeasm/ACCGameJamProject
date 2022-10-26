using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitScript : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    public GameObject playerGameObject;
    private void Awake() {
        Player.instance = new Player(playerGameObject, new BFLWeapon());
        AssetSource.Init();
        LanguageAsset.Init();
        AudioManager.Init();
    }
    private void Update() {
    }
}
