using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour
{
    public int health = 3;
    public float speed = 10f;
    public float jumpForce;

    public GameObject Bow;
    public Transform FirePoint;
    public AudioSource audioSourceArrow;

    private bool isJumping;
    private bool doubleJump;
    private bool isFiring;
    private float movement;

    private Rigidbody2D rig;
    private Animator anim;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        GameController.instance.UpdateHealthText(health);
    }

    void Update()
    {
        Jump();
        BowFire();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        movement = Input.GetAxis("Horizontal");
        rig.linearVelocity = new Vector2(movement * speed, rig.linearVelocity.y); // corrigido: linearVelocity para velocity

        if (movement > 0)
        {
            if (!isJumping)
            {
                anim.SetInteger("transition", 1);
            }
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (movement < 0)
        {
            if (!isJumping)
            {
                anim.SetInteger("transition", 1);
            }
            transform.eulerAngles = new Vector3(0, 180f, 0);
        }

        if (movement == 0 && !isJumping && !isFiring)
        {
            if (isFiring)
            {
                anim.SetInteger("transition", 0);
            }
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!isJumping)
            {
                anim.SetInteger("transition", 2);
                rig.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                doubleJump = true;
                isJumping = true;
            }
            else if (doubleJump)
            {
                anim.SetInteger("transition", 2);
                rig.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                doubleJump = false;
            }
        }
    }

    void BowFire()
    {
        StartCoroutine(fire());
    }

    IEnumerator fire()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isFiring = true;
            anim.SetInteger("transition", 3);
            GameObject bow = Instantiate(Bow, FirePoint.position, FirePoint.rotation);

            if (transform.rotation.y == 0)
            {
                bow.GetComponent<Bow>().isRight = true;
            }
            if (transform.rotation.y == 180)
            {
                bow.GetComponent<Bow>().isRight = false;
            }

            audioSourceArrow.Play();

            yield return new WaitForSeconds(0.2f);
            isFiring = false;
            anim.SetInteger("transition", 0);
        }
    }

    public void Damage(int dmg)
    {
        health -= dmg;
        GameController.instance.UpdateHealthText(health);
        anim.SetTrigger("hit");

        if (transform.rotation.x == 0)
        {
            transform.position += new Vector3(1f, 0, 0);
        }
        if (transform.rotation.x == 180)
        {
            transform.position += new Vector3(-1f, 0, 0);
        }

        if (health <= 0)
        {
            //Game Over
            GameController.instance.GameOver();
        }
    }

    public void IncreaseLife(int value)
    {
        health += value;
        GameController.instance.UpdateHealthText(health);
    }


    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.layer == 6)
        {
            isJumping = false;
        }
        if (collisionInfo.gameObject.layer == 7)
        {
            //Game Over
            GameController.instance.GameOver();
        }
    }
}
