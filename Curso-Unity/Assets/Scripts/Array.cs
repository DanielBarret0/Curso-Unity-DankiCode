using UnityEngine;

public class Array : MonoBehaviour
{
    public string[] meusInimigos = new string[] { "Orc", "Elfo", "Anões" };

    public GameObject[] inimigos;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(meusInimigos[1]); 
    }

    void Update()
    {
        
    }
}
