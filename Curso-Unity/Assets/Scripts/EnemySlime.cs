using UnityEngine;

public class EnemySlime : MonoBehaviour
{

    public float speedSlime = 5f;
    public float walkTimeSlime = 2f;
    public bool walkRigthSlime = true; // faz com que ele comece indo para esuqerda
    public int healthSlime;
    public int damageSlime = 1;
    private float timerSlime;
    private Rigidbody2D rigSlime;
    private Animator animSlime;

    void Start()
    {
        rigSlime = GetComponent<Rigidbody2D>();
        animSlime = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        timerSlime += Time.deltaTime;
        if (timerSlime >= walkTimeSlime)
        {
            walkRigthSlime = !walkRigthSlime;
            timerSlime = 0f;
        }

        if (walkRigthSlime)
        {
            transform.eulerAngles = new Vector2(0, 180);
            rigSlime.linearVelocity = Vector2.right * speedSlime;
        }
        else
        {
            transform.eulerAngles = new Vector2(0, 0);
            rigSlime.linearVelocity = Vector2.left * speedSlime;
        }
    }

    public void Damage(int dmgSlime)
    {
        
        healthSlime -= dmgSlime;
        animSlime.SetTrigger("hit");

        if (healthSlime <= 0)
        {
            // Destroi o inimigo
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collisionSlime)
    {
        if (collisionSlime.gameObject.CompareTag("Player"))
        {
            // Dano ao jogador
            collisionSlime.gameObject.GetComponent<Player1>().Damage(damageSlime);

        }
    }
}
