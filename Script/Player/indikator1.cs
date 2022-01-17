using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indikator1 : MonoBehaviour
{
    public GameObject imageIndikator2;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        imageIndikator2.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            imageIndikator2.SetActive(true);
            anim.Play("indikatorAnimator");

            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        imageIndikator2.SetActive(false);
    }
}
