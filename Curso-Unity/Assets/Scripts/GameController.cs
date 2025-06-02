using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text healthText;
    public int score;
    public Text scoreText;
    public static GameController instance;
    // Chamando antes de tds os Start de tds ops scripts
    void Awake()
    {
        instance = this;

    }

    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("score"));
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore(int value)
    {
        score += value;
        scoreText.text = score.ToString();
        // Variavel ficou com nome score SALVO
        PlayerPrefs.SetInt("score", score);
    }

    public void UpdateHealthText(int value)
    {
        healthText.text = "X "+ value.ToString();
    }
}
