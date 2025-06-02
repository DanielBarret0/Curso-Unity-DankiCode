using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text healthText;
    public static GameController instance;
    // Chamando antes de tds os Start de tds ops scripts
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateHealthText(int value)
    {
        healthText.text = "X "+ value.ToString();
    }
}
