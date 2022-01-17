using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

    [Header("Sound Effect Coin")]
    public AudioSource SoundCoin;
    public Slider VolumeSoundCoin;

    CoinMove coinScript;

    //public ParticleSystem LandingParticle;

    void Start()
    {
        coinScript = gameObject.GetComponent<CoinMove>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * 50, 0);

        transform.position = Vector3.MoveTowards(transform.position, coinScript.playerTransform.position,
        coinScript.moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
           

        }
        if (other.tag == "PlayerBubbel")
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
