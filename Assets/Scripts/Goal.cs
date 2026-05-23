using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string playerScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            playerScore += 1;
            Debug.Log(playerScored +"Player Score: " + playerScore);
            Destroy(collision.gameObject);
        }
    }
}
