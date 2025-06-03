using UnityEngine;

public class Coin : MonoBehaviour
{

    public int scoreValue;
    public AudioSource audioSourceCoin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSourceCoin.Play();
            GameController.instance.UpdateScore(scoreValue);
            GetComponent<SpriteRenderer>().enabled = false; // esconde a moeda
            GetComponent<Collider2D>().enabled = false;      // impede novo trigger
            Destroy(gameObject, audioSourceCoin.clip.length); // destrói após o som

        }
    }
}

