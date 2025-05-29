using UnityEngine;
using System.Collections.Generic;


public class ForEach : MonoBehaviour
{

    public string[] nomesNPC = new string[3];
    public List<string> nomesInimigos = new List<string>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nomesNPC[0] = "Mark";
        nomesNPC[1] = "Bob";
        nomesNPC[2] = "Julia";

        nomesInimigos.Add("Duratan");
        nomesInimigos.Add("Sauron");
        nomesInimigos.Add("Peter");

        //Tipo de item da coleção in coleção
        foreach (string elemento in nomesNPC)
        {
            Debug.Log(elemento);
        }

        // for (int i = 0; i < nomesNPC.Length; i++)
        // {
        //     Debug.Log(nomesNPC[i]);
        // }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
