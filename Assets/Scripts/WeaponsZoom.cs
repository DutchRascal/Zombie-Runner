using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponsZoom : MonoBehaviour
{

    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomOutSensivity = 2f;
    [SerializeField] float zoomInSensivity = .5f;

    bool zoomedInToggle = false;

    RigidbodyFirstPersonController fpsController;

    private void Start()
    {
        fpsController = GetComponent<RigidbodyFirstPersonController>();
    }

    private void Update()
    {
        CameraZoom();
    }

    void CameraZoom()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomedInToggle)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedInFOV;
                fpsController.mouseLook.XSensitivity = zoomInSensivity;
                fpsController.mouseLook.YSensitivity = zoomInSensivity;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedOutFOV;
                fpsController.mouseLook.XSensitivity = zoomOutSensivity;
                fpsController.mouseLook.YSensitivity = zoomOutSensivity;
            }
        }
    }
}
