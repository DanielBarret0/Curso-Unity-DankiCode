using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    public List<string> tiposInimigos = new List<string>();

    void Start()
    {
        tiposInimigos.Add("Nome1");
        tiposInimigos.Add("Nome2");
        tiposInimigos.Add("Nome3");

        tiposInimigos.Insert(0, "Lobo");

        if (tiposInimigos.Contains("Nome1"))
        {
            Debug.Log("Eciste um Orc");
        }
    }

    void Update()
    {

    }
}
