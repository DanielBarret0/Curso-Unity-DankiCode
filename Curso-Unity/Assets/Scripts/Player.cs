using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rig;
    private Animator anim;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        // ATAQUE
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("F pressionado");
            anim.SetBool("isAtk", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("F foi solto");
            anim.SetBool("isAtk", false);
        }


        // MOVIMENTAÇÃO
        if (Input.GetKey(KeyCode.D))
        {
            rig.linearVelocity = Vector2.right * speed;
            anim.SetBool("isRun", true);
            transform.eulerAngles = new Vector2(0, 180f);
            Debug.Log("D foi pressionado");

        }
        else if (Input.GetKey(KeyCode.A))
        {
            rig.linearVelocity = Vector2.left * speed;
            anim.SetBool("isRun", true);
            transform.eulerAngles = new Vector2(0, 0f);
            Debug.Log("A foi pressionado");
        }
        else
        {
            rig.linearVelocity = Vector2.zero;
            anim.SetBool("isRun", false);
        }
    }
}
