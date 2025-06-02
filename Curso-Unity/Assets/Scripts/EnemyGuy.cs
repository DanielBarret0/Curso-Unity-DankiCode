using UnityEngine;

public class EnemyGuy : MonoBehaviour
{

    public float speed = 5f;
    public float walkTime = 2f;
    public bool walkRigth = true; // faz com que ele comece indo para esuqerda
    public int health;
    public int damage = 1;
    private float timer;
    private Rigidbody2D rig;
    private Animator anim;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= walkTime)
        {
            walkRigth = !walkRigth;
            timer = 0f;
        }

        if (walkRigth)
        {
            transform.eulerAngles = new Vector2(0, 180);
            rig.linearVelocity = Vector2.right * speed;
        }
        else
        {
            transform.eulerAngles = new Vector2(0, 0);
            rig.linearVelocity = Vector2.left * speed;
        }
    }

    public void Damage(int dmg)
    {
        health -= dmg;
        anim.SetTrigger("hit");

        if (health <= 0)
        {
            // Destroi o inimigo
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Dano ao jogador
            collision.gameObject.GetComponent<Player1>().Damage(damage);

        }
    }
}
