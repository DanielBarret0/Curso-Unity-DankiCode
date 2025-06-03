using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_principal : MonoBehaviour
{
    public void VoltarParaMenu()
    {
        SceneManager.LoadScene(0); // Carrega a cena de índice 0
    }

}
