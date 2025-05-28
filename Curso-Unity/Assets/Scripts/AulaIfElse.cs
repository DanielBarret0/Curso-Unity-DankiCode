using UnityEngine;

public class AulaIfElse : MonoBehaviour
{
    public int numero = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (numero > 1)
        {
            Debug.Log("A condição é VERDADEIRA");
        }
        else
        {
            Debug.Log("A condição é FALSA");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
