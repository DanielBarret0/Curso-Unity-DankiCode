using UnityEngine;

public class AulaInstantiateDestroy : MonoBehaviour
{
    public GameObject capsule;

    void Start()
    {
        GameObject copiaCapsule = Instantiate(capsule, transform.position, transform.rotation);
        Destroy(copiaCapsule, 2f); // não precisa usar `.gameObject` aqui
    }

    void Update()
    {
        
    }
}
