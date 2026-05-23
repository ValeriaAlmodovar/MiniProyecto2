using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ballPrefab;   // prefab de la bola
    public Vector3 spawnPosition = new Vector3(0, 16, 30); // punto fijo donde cae

    public float startDelay = 2f;   // espera inicial
    public float spawnInterval = 10f; // cada cuánto cae

    void Start()
    {
        InvokeRepeating("SpawnBall", startDelay, spawnInterval);
    }

    void SpawnBall()
    {
        Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
    }
}