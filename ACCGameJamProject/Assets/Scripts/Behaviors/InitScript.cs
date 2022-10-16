using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitScript : MonoBehaviour
{
    private void Awake() {
        AssetSource.Init();
        LanguageAsset.Init();
    }
}
