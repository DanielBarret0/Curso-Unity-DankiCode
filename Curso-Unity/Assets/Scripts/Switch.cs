using UnityEngine;

public class Switch : MonoBehaviour
{

    public int forca;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (forca)
        {
            case 1:
                Debug.Log("Força igual a 1");
                break;
            case 2:
                Debug.Log("Força igual a 2");
                break;
            case 3:
                Debug.Log("Força igual a 3");
                break;
            case 4:
                Debug.Log("Força igual a 4");
                break;
            case 5:
                Debug.Log("Força igual a 5");
                break;
            default:
                Debug.Log("Não possui valor");
                break;
        }   
    }
}
