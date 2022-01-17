using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [Header("Game Object Finish")]
    public GameObject finish;

    public GameObject Bintang1;
    public GameObject Bintang2;
    public GameObject Bintang3;

    public static bool finishCondition;
    public static bool bintang1;
    public static bool bintang2;
    public static bool bintang3;

    void Start()
    {
        finishCondition = false;
        bintang1 = false;
        bintang2 = false;
        bintang3 = false;
    }

    void Update()
    {
        if (finishCondition)
        {
            finish.gameObject.SetActive(true);

        }
        if (bintang1)
        {
            Bintang1.gameObject.SetActive(true);
        }
        if (bintang2)
        {
            Bintang2.gameObject.SetActive(true);
        }
        if (bintang3)
        {
            Bintang3.gameObject.SetActive(true);
        }
    }
}
