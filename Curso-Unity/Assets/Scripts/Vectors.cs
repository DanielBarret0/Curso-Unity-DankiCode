using UnityEngine;

public class Vectors : MonoBehaviour
{

    // Usado para jogs 2d
    public Vector2 pos;
    // Usado para jogos 3d
    public Vector3 pos2;



    void Start()
    {
        pos = new Vector2(1f, 1f);
        pos.y = 4;
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
