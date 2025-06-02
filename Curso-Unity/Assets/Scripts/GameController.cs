using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text healthText;
    public int score;
    public Text scoreText;
    public int totalScore;
    public static GameController instance;
    // Chamando antes de tds os Start de tds ops scripts
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        totalScore = PlayerPrefs.GetInt("score");
        Debug.Log("Total Score: " + totalScore);	
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore(int value)
    {   
        //Soma e atribui o valor ao score/Moeda
        score += value;
        scoreText.text = score.ToString();
        // Variavel ficou com nome score SALVO
        PlayerPrefs.SetInt("score", score + totalScore);
    }

    public void UpdateHealthText(int value)
    {
        healthText.text = "X "+ value.ToString();
    }
}
