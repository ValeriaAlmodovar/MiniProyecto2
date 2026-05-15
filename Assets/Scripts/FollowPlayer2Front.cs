using UnityEngine;

public class FollowPlayer2Front : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject player;
    private Vector3 offset = new Vector3(0, 2, 0);

    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        
    }
}