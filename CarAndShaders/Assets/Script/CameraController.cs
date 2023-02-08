using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraController : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    // Start is called before the first frame update
    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
