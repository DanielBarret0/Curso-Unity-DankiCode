using UnityEngine;

public class Cam : MonoBehaviour
{
    private Transform player;
    public float smooth = 5f;  // Valor padrão para smooth

    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
            player = playerObj.transform;
        else
            Debug.LogError("Player not found!");
    }

    void LateUpdate()
    {
        if (player == null) return;

        Vector3 targetPosition = new Vector3(player.position.x, transform.position.y, transform.position.z);

        // Limitar posição X para não ficar menor que 0
        if (targetPosition.x < 0)
            targetPosition.x = 0;

        transform.position = Vector3.Lerp(transform.position, targetPosition, smooth * Time.deltaTime);
    }
}
