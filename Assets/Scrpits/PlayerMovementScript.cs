using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovementScript : MonoBehaviour
{
    public static PlayerMovementScript instance;
    public float movex;
    public float moveSpeed;
    //  public GameObject bullet;
    public GameObject pow;
    //  public Text DogRescorces;
    private Animator anim;
    //public GameObject Player;
    private AudioSource source;
    public Rigidbody2D rb;
    Vector3 characterScale;
    float characterScalex;
    bool isgrounded = true;
    public bool facingright = true;
    public AudioClip dogdeath;
    public int boneCount = 0;
    public int HealthCount = 100;
    public Text HealthText;

    public Vector3 Respawnpoint;
    public GameObject bloodsplat;
    public screenShake shakeScreen;
    public float distance;
    public LayerMask whatisLadder;
    private bool isClimbing;
    private float inputVertical;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        characterScale = transform.localScale;
        characterScalex = characterScale.x;

        Respawnpoint = transform.position;
        source = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        //rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //HealthText.text = "Health : " + HealthCount;
    }
    void FixedUpdate()
    {

        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

        if (move < 0) GetComponent<Rigidbody2D>().velocity = new Vector3(move * moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        if (move > 0) GetComponent<Rigidbody2D>().velocity = new Vector3(move * moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move < 0 && facingright) Flip();
        if (move > 0 && !facingright) Flip();
    }

        void Flip()
        {
            facingright = !facingright;
            transform.Rotate(Vector3.up * 180);
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "CheckPoint")
            {
                Respawnpoint = other.transform.position;
            }


        }

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.tag == "mvp")
                transform.parent = other.transform;
        }

        void OnCollisionExit2D(Collision2D other)
        {
            if (other.gameObject.tag == "mvp")
                transform.parent = null;
        }


    


        public IEnumerator KnockBack(float knockBackTime, float knockBackPower, Transform obj)
        {
            float timer = 0;
            while (knockBackTime > timer)
            {
                timer += Time.deltaTime;

                rb.AddForce(Vector3.back * knockBackPower);
            }
            yield return 0;
        }


    }

   