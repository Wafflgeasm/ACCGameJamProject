using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitScript : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    private void Awake() {
        AssetSource.Init();
        LanguageAsset.Init();
        AudioManager.Init();
    }
    private void Update() {
    }
}
