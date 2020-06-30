using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour {
    Camera cam;
    void Start()
    {
        cam = Camera.main;
    }
    private void Update()
    {
        cam.gameObject.transform.Translate(new Vector3(0.0f, 0.0f, 9.0f));
    }
}