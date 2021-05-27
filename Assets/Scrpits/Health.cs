using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image heart1;
    public Image heart2;
    public Image heart3;
    public GameObject blood;
    public Sprite heartfull;
    public Sprite hearthalf;
    public Sprite heartEmpty;
    public PlayerMovementScript Player;
    public int maxHealth;
    public int HealthCount;
    private AudioSource audioSource;
    public float waitToRespawn;
    private bool Respawing;
    private SpriteRenderer SP;
    public int damage;
   
    void Start()
    {
        HealthCount = maxHealth;
        Player = FindObjectOfType<PlayerMovementScript>();
        SP = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (HealthCount <= 0 && !Respawing)
        {
            Respawing = true;
            Respawn();

        }
        
    }
    public void HurtPlayer(int damageToTake)
    {
        HealthCount -= damageToTake;
        UpdateHearts();
    }
    
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "killfloor")
        {
            HealthCount = 0;
        }
        if(other.gameObject.tag == "Bomb")
        {
            HealthCount -= damage;
            UpdateHearts();
        }
    }

    public void Respawn()
    {
        StartCoroutine("RespawnCo");
    }
    private IEnumerator RespawnCo()
    {
        Color SPColor = Color.white;
        SPColor.a = 0;
        Instantiate(blood, transform.position, Quaternion.identity);
        SP.color = SPColor;
        print("playerinActive");
        yield return new WaitForSeconds(waitToRespawn);

        HealthCount = maxHealth;
        Respawing = false;
        print("respwan");
        Player.transform.position = Player.Respawnpoint;
        SPColor.a = 1;
        SP.color = SPColor;
        UpdateHearts();
    }
    public void UpdateHearts()
    {
        switch (HealthCount)
        {
            case 6:
                heart1.sprite = heartfull;
                 heart2.sprite = heartfull;
                 heart3.sprite = heartfull;
                return;

            case 5:
                heart1.sprite = heartfull;
                heart2.sprite = heartfull;
                heart3.sprite = hearthalf;
                return;

            case 4:
                heart1.sprite = heartfull;
                heart2.sprite = heartfull;
                heart3.sprite = heartEmpty;
                return;

            case 3:
                heart1.sprite = heartfull;
                heart2.sprite = hearthalf;
                heart3.sprite = heartEmpty;
                return;


            case 2:
                heart1.sprite = heartfull;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;
                return;
            case 1:
                heart1.sprite = hearthalf;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;
                return;
            case 0:
                heart1.sprite = heartEmpty;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;
                return;

            default:
                heart1.sprite = heartEmpty;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;
                return;
        }
    }
    public void Addlives(int livestoadd)
    {
    HealthCount += livestoadd;
        UpdateHearts();
    }
}   
