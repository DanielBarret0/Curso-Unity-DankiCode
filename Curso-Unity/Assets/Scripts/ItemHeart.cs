using UnityEngine;

public class ItemHeart : MonoBehaviour
{
    public int healthValue;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player1>().IncreaseLife(healthValue);
            Destroy(gameObject);
        }
    }
}
