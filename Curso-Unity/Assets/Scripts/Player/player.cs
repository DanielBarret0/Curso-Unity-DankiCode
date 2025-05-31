using UnityEngine;

public class player : MonoBehaviour
{

    public float speed = 3f;
    public float jumpForce = 5f;

    private Rigidbody2D rig;
    private Animator anim;

    void Start()
    {
        // ao inicialiar o player, pega o componente Rigidbody2D e Animator
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        // Parado valor é 0, Direito valor Max 1, Esquerda valor Max -1
        float movement = Input.GetAxis("Horizontal");
        // Adiciona velocidade ao corpo no eixo X e y
        rig.linearVelocity = new Vector2(movement * speed, rig.linearVelocity.y);

        // Andando pra direita
        if (movement > 0) {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        // Andando pra esquerda
        if (movement < 0) {
            transform.eulerAngles = new Vector3(0, 180f, 0);
        }
    }

    void Jump()
    {
        
    }
}
