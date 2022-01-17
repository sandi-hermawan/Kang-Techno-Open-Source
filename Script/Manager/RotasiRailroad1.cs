using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotasiRailroad1 : MonoBehaviour
{
    public Quaternion startQuaternion;

    public Vector3 quaternionToVector;
    public Vector3 reverseQuaternion;

    public float lerfTime = 1f;
    public float rotateAmount = 1;

    public static bool rotate;
    public bool rotateConstantly;

    void Start()
    {
        startQuaternion = transform.rotation;
       
    }

    void Update()
    {
        if (rotate)
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(reverseQuaternion), Time.deltaTime * lerfTime);
        if(rotateConstantly && !rotate)
        {
            transform.Rotate(Vector3.up * rotateAmount);
        }
        
    }

    public void snapRotation()
    {
        transform.rotation = startQuaternion;
    }
}
