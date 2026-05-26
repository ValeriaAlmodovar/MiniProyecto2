using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ballPrefab;   // prefab de la bola
    public Vector3 spawnPosition = new Vector3(0, 16, 83.5f); // punto fijo donde cae

    public float startDelay = 2f;   // espera inicial
    public float spawnInterval = 10f; // cada cuánto cae
    
    [SerializeField] private Rigidbody ballRb;

    void Start()
    {
        InvokeRepeating("SpawnBall", startDelay, spawnInterval);
    }

    private void Awake()
    {
        ballRb = ballPrefab.GetComponent<Rigidbody>();
    }

    void SpawnBall()
    {
        Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
    }

    public float GetSpeed()
    {
        return ballRb.linearVelocity.magnitude;
    }
}