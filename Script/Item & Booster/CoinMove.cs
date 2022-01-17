using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    public Transform playerTransform;
    public float moveSpeed = 17f;

    Coin coinMoveScript;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        coinMoveScript = gameObject.GetComponent<Coin>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CoinDetector")
        {
            coinMoveScript.enabled = true;
        }

    }
}
