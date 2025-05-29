using UnityEngine;

public class TranslateRotation : MonoBehaviour
{


    public float velocidade;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 5f);
        transform.Rotate(2f, 1f, 0f, Space.Self);

    }
}