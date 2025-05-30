using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{


    public Text myText;
    public string newText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            
        }
    }

    public void ChangeText()
    {
        myText.text = newText;
    }
}
