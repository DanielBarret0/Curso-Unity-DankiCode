using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Inimigo.meuInimigo.vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
