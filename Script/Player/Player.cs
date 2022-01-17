
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public enum SIDE { Left, Mid, Right }

public class Player : MonoBehaviour
{
    public SIDE m_Side = SIDE.Mid;

    float NewXpos = 0f;

    public float XValue;
    public float forwardSpeed;
    public float JumpPower = 7f;
    public float SpeedDodge;

    public bool SwipeLeft, SwipeRight, SwipeUp, SwipeDown;
    public bool InJump;
    public bool InSlide;

    public static float RealSpeed = 5.0f;
    public static float BoosterSpeed = 1.0f;

    public static int numberOfCoin;
    public TextMeshProUGUI coinsText;

    [Header("Sound Effect Jump")]
    public AudioSource SoundJump;
    public Slider VolumeSoundJump;

    [Header("Sound Effect Slide")]
    public AudioSource SoundSlide;
    public Slider VolumeSoundSlide;

    private float y;
    private float x;
    private float ColHeight;
    private float ColCenterY;


    private CharacterController m_char;
    private Vector3 direction;
    private Animator anim;

    void Start()
    {

        m_char = GetComponent<CharacterController>();
        ColHeight = m_char.height;
        ColCenterY = m_char.center.y;
        transform.position = Vector3.zero;
        anim = GetComponent<Animator>();
        numberOfCoin = 0;

    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = "Coin: " + numberOfCoin;

        direction.z = forwardSpeed;

        SwipeLeft = Input.GetKeyDown(KeyCode.A) || (SwipeManager.swipeLeft);
        SwipeRight = Input.GetKeyDown(KeyCode.D) || (SwipeManager.swipeRight);
        SwipeUp = Input.GetKeyDown(KeyCode.W) || (SwipeManager.swipeUp);
        SwipeDown = Input.GetKeyDown(KeyCode.S) || (SwipeManager.swipeDown);

        if (SwipeLeft && !InSlide)
        {
            if (m_Side == SIDE.Mid)
            {
                NewXpos = -XValue;
                m_Side = SIDE.Left;

                anim.Play("RUN00_L");
            }
            else if (m_Side == SIDE.Right)
            {
                NewXpos = 0f;
                m_Side = SIDE.Mid;

                anim.Play("RUN00_L");
            }
        }
        if (SwipeRight && !InSlide)
        {
            if (m_Side == SIDE.Mid)
            {
                NewXpos = XValue;
                m_Side = SIDE.Right;

                anim.Play("RUN00_R");
            }
            else if (m_Side == SIDE.Left)
            {
                NewXpos = 0f;
                m_Side = SIDE.Mid;

                anim.Play("RUN00_R");
            }
        }
        Vector3 moveVector = new Vector3(x - transform.position.x, y * Time.deltaTime, forwardSpeed * Time.deltaTime);
        x = Mathf.Lerp(x, NewXpos, Time.deltaTime * SpeedDodge);
        m_char.Move(moveVector);
        Jump();
        Slide();

    }

    public void Jump()
    {
        if (m_char.isGrounded)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName(""))//animasi mendarat samain dengan yang di bagian else (klo mau diisi)
            {
                SoundJump.GetComponent<AudioSource>().Play();
                SoundJump.volume = VolumeSoundJump.value;
                //anim.Play("");//animasi landing
                InJump = false;

            }

            if (SwipeUp)
            {
                SoundJump.GetComponent<AudioSource>().Play();
                SoundJump.volume = VolumeSoundJump.value;
                y = JumpPower;
                anim.CrossFadeInFixedTime("JUMP", 0.1f); //untuk animasi loncar
                InJump = true;
            }
        }
        else
        {
            y -= JumpPower * 2 * Time.deltaTime;
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
            SlideCounter = 0.7f;
            y -= 10f;
            m_char.center = new Vector3(0, ColCenterY / 2f, 0);
            m_char.height = ColHeight / 2f;
            anim.CrossFadeInFixedTime("SLIDE00", 0.1f);
            InSlide = true;
            InJump = false;
        }
    }
}

