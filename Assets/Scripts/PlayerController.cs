using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 35f;
    private float turnSpeed = 45f;
    private float jumpSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public float horizontalInput = 0;
    public float forwardInput = 0;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
            horizontalInput = -1;
        if(Input.GetKey(KeyCode.D))
            horizontalInput = 1;
        if(Input.GetKey(KeyCode.W))
            forwardInput = 1;
        if(Input.GetKey(KeyCode.S))
            forwardInput = -1;

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 hitDirection = (collision.transform.position - transform.position).normalized;
            float force = 10f;
            ballRb.AddForce(hitDirection * force, ForceMode.Impulse);
        }
    }
}
