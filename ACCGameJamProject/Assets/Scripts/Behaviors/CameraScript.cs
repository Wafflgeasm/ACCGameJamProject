using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private void Update() {
        if (Player.instance.gameObject == null) return;
        transform.position = Player.instance.gameObject.transform.position-Vector3.forward;
    }
}
