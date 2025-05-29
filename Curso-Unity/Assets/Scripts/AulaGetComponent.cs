using UnityEngine;

public class AulaGetComponent : MonoBehaviour
{
    public Rigidbody rig;
    public BoxCollider2D box;
    private GameObject Player;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
