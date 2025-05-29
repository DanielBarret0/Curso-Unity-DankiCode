using UnityEngine;

public class Metodos : MonoBehaviour
{

    public string nome;
    int vida;
    int velocidade;
    int forcaPulo;

    private void Start()
    {
        Atacar();
    }
    // Metodo
    public void Atacar()
    {
        Debug.Log("Método ATACAR");
    }
    // Metodo
    string DefinirNome()
    {
        nome = "Player One";
        return nome;
    }

    
}
