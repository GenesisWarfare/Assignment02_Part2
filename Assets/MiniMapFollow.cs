using UnityEngine;

public class MiniMapFollow : MonoBehaviour
{
    public Transform player;

    void LateUpdate()
    {
        Vector3 newPos = player.position;
        newPos.z = transform.position.z; // keep camera Z
        transform.position = newPos;
    }
}
