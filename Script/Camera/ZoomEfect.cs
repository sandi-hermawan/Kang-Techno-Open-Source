using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ZoomEfect : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera virtualCamera;
    CinemachineComponentBase componentBase;

    float cameraDistance;

    [SerializeField] float sensitivity = 10f ;

    void Start()
    {

    }

    void Update()
    {
        if (componentBase == null)
        {
            componentBase = virtualCamera.GetCinemachineComponent(CinemachineCore.Stage.Body);
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {

            cameraDistance = Input.GetAxis("Mouse ScrollWheel") * sensitivity;
            if (componentBase is CinemachineFramingTransposer)
            {
                (componentBase as CinemachineFramingTransposer).m_CameraDistance -= cameraDistance;
            }
        }

    }

}