using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform cameraTransform;
    public float speedRun;
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    void LateUpdate()
    {
        cameraTransform.position += new Vector3(speedRun, 0);
    }
}
