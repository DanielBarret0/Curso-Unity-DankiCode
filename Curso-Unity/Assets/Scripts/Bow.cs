using UnityEngine;

public class Bow : MonoBehaviour
{
    public float speed = 5f; // ✅ Corrigido: declaração da variável speed
    private Rigidbody2D rig;
    public bool isRight;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 4f);
    }

    void FixedUpdate()
    {
        if (isRight) {
            rig.linearVelocity = Vector2.right * speed;
        }
        else
        {
            rig.linearVelocity = Vector2.left * speed;
        }
        
    }
}
