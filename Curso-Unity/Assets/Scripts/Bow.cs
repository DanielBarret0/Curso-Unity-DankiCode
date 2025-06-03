using UnityEngine;

public class Bow : MonoBehaviour
{
    public float speed = 5f;
    public int damage;
    private Rigidbody2D rig;
    public bool isRight;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 4f);
    }

    void FixedUpdate()
    {
        if (isRight)
        {
            rig.linearVelocity = Vector2.right * speed;
        }
        else
        {
            rig.linearVelocity = Vector2.left * speed;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("Enemy"))
    {
        EnemyGuy enemyGuy = collision.GetComponent<EnemyGuy>();
        if (enemyGuy != null)
        {
            enemyGuy.Damage(damage);
        }

        EnemySlime enemySlime = collision.GetComponent<EnemySlime>();
        if (enemySlime != null)
        {
            enemySlime.Damage(damage);
        }

        Destroy(gameObject);
    }
}
}
