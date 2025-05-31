using UnityEngine;

public class Player1 : MonoBehaviour
{

    public float speed = 3f;
    public float jumpForce = 8f;

    private bool isJumping;
    private bool doubleJump;

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
        Jump();
    }

    void Move()
    {
        // Parado valor é 0, Direito valor Max 1, Esquerda valor Max -1
        float movement = Input.GetAxis("Horizontal");
        // Adiciona velocidade ao corpo no eixo X e y
        rig.linearVelocity = new Vector2(movement * speed, rig.linearVelocity.y);

        // Andando pra direita
        if (movement > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        // Andando pra esquerda
        if (movement < 0)
        {
            transform.eulerAngles = new Vector3(0, 180f, 0);
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!isJumping)
            {
                rig.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                doubleJump = true;
                isJumping = true;
            }
            else
            {
                if (doubleJump)
                {
                    rig.AddForce(new Vector2(0, jumpForce * 2), ForceMode2D.Impulse);
                    doubleJump = false;
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.layer == 8)
        {
            isJumping = false;
        }
    }
}
