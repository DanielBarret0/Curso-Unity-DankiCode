using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inimigo : MonoBehaviour
{

    public int vida;

    public static Inimigo meuInimigo;

    void Start()
    {
        // meuInimigo receve a propria classe
        meuInimigo = this;
    }

}
