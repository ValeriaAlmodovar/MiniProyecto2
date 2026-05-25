using UnityEngine;

public class FollowPlayer1Main : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -11.5f);
    private Vector3 rotatedOffset = new Vector3(0, 6, -11.5f);

    private void LateUpdate()
    {
        rotatedOffset = player.transform.rotation * offset;
        transform.position = player.transform.position + rotatedOffset;
        transform.LookAt(player.transform);
    }
}