using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text healthText;
    public int score;
    public Text scoreText;
    public int totalScore;

    public GameObject pauseObje;
    public GameObject gameOverObj;
    private bool isPaused = false;
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
        //aqui chamo a função de pausar o jogo
        PauseGame();
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
        healthText.text = "X " + value.ToString();
    }

    // lógica de pausa do jogo
    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            pauseObje.SetActive(isPaused);
        }

        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void GameOver()
    {   
        Debug.Log("GameOver chamado - pausando o jogo");
        isPaused = true;  
        gameOverObj.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
