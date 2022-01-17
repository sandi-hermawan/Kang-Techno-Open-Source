using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Collections;

public class Player_1Jalur : MonoBehaviour
{

    float NewXpos = 2f;

    public float XValue;

    public static float forwardSpeed;
    public static float JumpPower;
    public float Gravity = 1f;

    public bool SwipeUp, SwipeDown;
    public bool InJump;
    public bool InSlide;

    public static float RealSpeed = 5.0f;
    public static float BoosterSpeed = 1.0f;

    public static int numberOfCoin;
    public TextMeshProUGUI coinsText;

    public Camera cam;

    public GameObject PanelTutorial;

    [Header("Sound Effect Jump")]
    public AudioSource SoundJump;
    public AudioSource VoiceJump;
    public Slider VolumeSoundJump;

    [Header("Sound Effect Slide")]
    public AudioSource SoundSlide;
    public Slider VolumeSoundSlide;

    [Header("Sound Effect Crash")]
    public AudioSource SoundCrash;
    public AudioSource SoundCrashBigObstacle;
    public Slider VolumeSoundCrash;
    public Slider VolumeSoundCrashBigObstacle;

    [Header("Sound Effect Lose")]
    public AudioSource SoundLose;
    public Slider VolumeSoundLose;

    [Header("Sound Effect Winner")]
    public AudioSource SoundWinner;
    public Slider VolumeSoundWinner;

    private float xVel = 0;
    private float yVel = 0;
    private float zVel = 5;

    private float y;
    private float x = 2f;
    private float ColHeight;
    private float ColCenterY;


    private CharacterController m_char;
    private Vector3 direction;
    private Animator anim;

    public static int Health = 3;
    [SerializeField] private Image[] hearts;
    [SerializeField]  ParticleSystem jumpParticle = null;
    [SerializeField]  ParticleSystem slideParticle = null;

    void Start()
    {
        JumpPower = 8f;
        forwardSpeed = 11f;//11
        Health = 3;
        PanelTutorial.SetActive(true);

        waypointManager.speed = 0;
        waypointAngkot.speed = 0;
        RotasiRailroad.rotate = false;


        m_char = GetComponent<CharacterController>();
        //transform.position = Vector3.zero;
        anim = GetComponent<Animator>();

        ColHeight = m_char.height;
        ColCenterY = m_char.center.y;

        numberOfCoin = 0;
        Debug.Log("Health : " + Health);

    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = "" + numberOfCoin;

        direction.z = forwardSpeed;


        SwipeUp = Input.GetKeyDown(KeyCode.W) || (SwipeManager.swipeUp);
        SwipeDown = Input.GetKeyDown(KeyCode.S) || (SwipeManager.swipeDown);
        if (forwardSpeed == 0)
        {
            SwipeDown = false;
            SwipeUp = false;
        }

        Vector3 moveVector = new Vector3(x - transform.position.x, y * Time.deltaTime, forwardSpeed * Time.deltaTime);
        x = Mathf.Lerp(x, NewXpos, Time.deltaTime);
        m_char.Move(moveVector);
        Jump();
        Slide();

    }
        //Transform Rotation
        /*if(Input.GetKeyDown("a"))
        {
            zVel = 0;
            xVel = -5;

            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, -2, 0);
            m_char.Move(moveVector);
            StartCoroutine(Rotation());
        }
        GetComponent<Rigidbody>().velocity = new Vector3(xVel, yVel, zVel);

    }

    IEnumerator Rotation()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        GetComponent<Transform>().eulerAngles = new Vector3(0, -90, 0);



    }*/
    public void Jump()
    {
        if (m_char.isGrounded)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName(""))//animasi mendarat setelah loncat
            {
                SoundJump.GetComponent<AudioSource>().Play();
                SoundJump.volume = VolumeSoundJump.value;
                //anim.Play("");//animasi landing
                InJump = false;

            }

            if (SwipeUp)
            {
                SoundJump.GetComponent<AudioSource>().Play();
                VoiceJump.GetComponent<AudioSource>().Play();
                SoundJump.volume = VolumeSoundJump.value;
                VoiceJump.volume = VolumeSoundJump.value;
                y = JumpPower;
                anim.CrossFadeInFixedTime("JUMP", 0.1f); //untuk animasi loncat
                InJump = true;

                jumpParticle.Play();
            }
        }
        else
        {
            y -= JumpPower * Gravity * Time.deltaTime;
            if (m_char.velocity.y < -0.1f)/*anim.Play("")*/;//kalo mau di isi, ini untuk animasi mendarat

        }
    }

    internal float SlideCounter;

    public void Slide()
    {
        SlideCounter -= Time.deltaTime;
  
        if (SlideCounter <= 0f)
        {
            SlideCounter = 0f;
            m_char.center = new Vector3(0, ColCenterY, 0);
            m_char.height = ColHeight;
            InSlide = false;
        }
        if (SwipeDown)
        {
            SoundSlide.GetComponent<AudioSource>().Play();
            SoundSlide.volume = VolumeSoundSlide.value;
            SlideCounter = 0.65f;
            y -= 10f;
            m_char.center = new Vector3(0, ColCenterY / 2f, 0);
            m_char.height = ColHeight / 3f ;
            anim.CrossFadeInFixedTime("SLIDE00", 0.1f);
            slideParticle.Play();

            InSlide = true;
            InJump = false;
        }
    }
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.transform.tag == "waypointAngkot")
        {
            waypointAngkot.speed = 23;

        }
        if (hit.transform.tag == "waypointTrigger" )
        {
            waypointManager.speed = 27;
            RotasiRailroad.rotate = true;

        }

        if (hit.transform.tag == "Finish")
        {
            SoundWinner.GetComponent<AudioSource>().Play();
            SoundWinner.volume = VolumeSoundWinner.value;

            Finish.finishCondition = true;
            Score.StopScore();

            anim.Play("WIN00");

            forwardSpeed = 0;

            for (int i = 0; i < hearts.Length; i++)
            {
                
                   hearts[i].gameObject.SetActive(false);
                
            }

            if(Health == 3)
            {
                Finish.bintang1 = true;
                Finish.bintang2 = true;
                Finish.bintang3 = true;
            }
            else if(Health == 2)
            {
                Finish.bintang1 = true;
                Finish.bintang2 = true;

            }
            else if(Health == 1)
            {
                Finish.bintang1 = true;
            }
        }

        if (hit.transform.tag == "Small Obstacle")
        {
            Health = Health - 1;


            for (int i = 0; i < hearts.Length; i++)
            {
                if (i < Health)
                {
                    hearts[i].color = Color.yellow;
                }
                else
                {

                    hearts[i].gameObject.SetActive(false);

                    //CameraShake.Instance.SetShake(5f, .1f);
                }
            }
            SoundCrash.GetComponent<AudioSource>().Play();
            SoundCrash.volume = VolumeSoundCrash.value;

            Debug.Log("Health : " + Health);
            //play animasi di bawah
            anim.Play("DAMAGED00");

            if (Health == 0)
            {
                SoundLose.GetComponent<AudioSource>().Play();
                SoundLose.volume = VolumeSoundLose.value;

                anim.Play("DAMAGED01");
                GameOver.GameOverCondition = true;
                Score.StopScore();

                forwardSpeed = 0;

            }
        }

        if (hit.transform.tag == "Big Obstacle")
        {
            Health = 0;
            forwardSpeed = 0;
            Debug.Log("hit");

            SoundCrashBigObstacle.GetComponent<AudioSource>().Play();
            SoundCrashBigObstacle.volume = VolumeSoundCrashBigObstacle.value;
            SoundLose.GetComponent<AudioSource>().Play();
            SoundLose.volume = VolumeSoundLose.value;

            for (int i = 0; i < hearts.Length; i++)
            {
                if (i < Health)
                {
                    hearts[i].color = Color.yellow;
                }
                else
                {
                    hearts[i].gameObject.SetActive(false);
                }

                //play animasi di bawah
                anim.Play("DAMAGED01");

                if (Health == 0)
                {
                    GameOver.GameOverCondition = true;
                    Score.StopScore();

                    forwardSpeed = 0;
                    


                }

            }

        }

    }
}
