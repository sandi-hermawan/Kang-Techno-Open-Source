using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake Instance { get; private set; }

    //cinemachine
    private CinemachineVirtualCamera VirtualCamera;
    private float shakeTimer;
    private float shakeTimerTotal;
    private float startingIntensity;

    void Awake()
    {
        Instance = this;
        VirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(shakeTimer > 0)
        {
            shakeTimer -= Time.deltaTime;
                CinemachineBasicMultiChannelPerlin cinemachine = VirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

                cinemachine.m_AmplitudeGain = Mathf.Lerp(startingIntensity, 0f, shakeTimer / shakeTimerTotal);
        }
    }
   public void SetShake(float intensity, float time)
    {
        CinemachineBasicMultiChannelPerlin cinemachine = VirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        cinemachine.m_AmplitudeGain = intensity;

        startingIntensity = intensity;
        shakeTimerTotal = time;
        shakeTimer = time;
    }
}
