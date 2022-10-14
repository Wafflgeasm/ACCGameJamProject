using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWidthFixerScript : MonoBehaviour
{
    public float width;
    public bool update = false;
    new Camera camera;
    void Start()
    {
        camera = GetComponent<Camera>();
        camera.orthographicSize = width / Screen.safeArea.width * Screen.safeArea.height / 2;
    }

    void Update()
    {
        if (!update) return;
        camera.orthographicSize = width / Screen.safeArea.width * Screen.safeArea.height / 2;
    }
}
