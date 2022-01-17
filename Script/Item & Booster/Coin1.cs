using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin1 : MonoBehaviour
{

    [Header("Sound Effect Coin")]
    public AudioSource SoundCoin;
    public Slider VolumeSoundCoin;


    //public ParticleSystem LandingParticle;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * 50, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
        
            //LandingParticle.Play();
            Player.numberOfCoin += 1;
            Player_2Jalur.numberOfCoin += 1;
            Player_1Jalur.numberOfCoin += 1;
            Debug.Log("Coins:" + Player.numberOfCoin);

            //SoundEffect
            SoundCoin.GetComponent<AudioSource>().Play();
            SoundCoin.volume = VolumeSoundCoin.value;

            Destroy(gameObject);

        }
    }
}
