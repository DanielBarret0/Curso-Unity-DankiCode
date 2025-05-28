using UnityEngine;

public class WhileDoWhile : MonoBehaviour
{

    int vida = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enquanto
        // while (vida < 10)
        // {
        //     vida++;
        //     Debug.Log(vida);
        // }

        do
        {
            Debug.Log(vida);
            vida++;
        } while (vida < 10);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
