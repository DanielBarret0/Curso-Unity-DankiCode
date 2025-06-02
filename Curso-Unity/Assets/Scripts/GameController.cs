using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text healthText;
    public static GameController instance;
    void Start()
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
