using UnityEngine;

public class FollowPlayer2Main : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -12);

    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        
    }
}