using UnityEngine;

public class For : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int contador;
        // for(Comando de inicalização; condição; incremento/decremento){}
        for (contador = 0; contador < 10; contador++)
        {
            Debug.Log(contador);
        }
        Debug.Log("O valor final do contador é " + contador);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
