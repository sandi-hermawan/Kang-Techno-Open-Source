using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indikator : MonoBehaviour
{
    public GameObject imageIndikator1;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        imageIndikator1.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            imageIndikator1.SetActive(true);
            anim.Play("indikatorAnimator");

        }
    }
    private void OnTriggerExit(Collider other)
    {
        imageIndikator1.SetActive(false);
    }
}
