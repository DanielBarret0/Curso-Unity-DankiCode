using UnityEngine;

public class ClassesConstrutores : MonoBehaviour
{
    public class Arma
    {
        string nome;
        string tipo;

        public Arma(string armaNome, string armaTipo)
        {
            nome = armaNome;
            tipo = armaTipo;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string Nome)
        {
            nome = Nome;
        }
    }

    int vida;
    int velocidade;
    Arma espada;

    void Start()
    {
        espada = new Arma("Minha Espada", "Espada");
        Debug.Log(espada.getNome());

        espada.setNome("Agulha");
        Debug.Log(espada.getNome());
    }

    void Atacar()
    {
        
    }

    void Pular()
    {
        
    }
}
