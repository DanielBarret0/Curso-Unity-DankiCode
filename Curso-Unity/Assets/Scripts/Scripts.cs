using UnityEngine;

public class Scripts : MonoBehaviour
{
    // Tipos de Variaveis
    // Inteiro
    public int vida = 10;
    // Número flutuante
    private float forca = 10.5f;
    // Boleano
    private bool estarVivo = true;
    // Unity
    GameObject player;
    // Unity
    Rigidbody rig;

    // É chamado uma vez ao inicializar
    void Start()
    {
        Debug.Log(vida);
    }

    // É chamda a cada frame
    void Update()
    {

    }
}
