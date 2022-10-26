using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InviwallScript : MonoBehaviour
{
    private void Awake() {
        GetComponent<SpriteRenderer>().color = Color.clear;
    }
}
