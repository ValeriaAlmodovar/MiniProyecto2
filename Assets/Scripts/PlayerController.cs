using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float acceleration;
    [SerializeField] private float jumpForce;

    private bool movementKeyPressed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = new Vector3(0f, -0.5f, 0f);
    }

    private void Update()
    {
        ResetCar();
        Move();
        Turn();
        Jump();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (speed < maxSpeed)
            {
                speed += acceleration * Time.deltaTime;
            }
            rb.transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            if (speed > (-1 * maxSpeed))
            {
                speed -= acceleration * Time.deltaTime;
            }
            rb.transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        }
        movementKeyPressed = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S);
        if (movementKeyPressed) return;
        if (speed >= 0)
        {
            speed -= (1f * acceleration) * Time.deltaTime;
        }

        if (speed <= 0)
        {
            speed += (1f * acceleration) * Time.deltaTime;
        }
        rb.transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        if (speed < 0.2 && speed > -0.2) speed = 0;
    }

    private void Turn()
    {
        if (speed < 0.2 && speed > -0.2) return;
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.Rotate(Vector3.down * (turnSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.transform.Rotate(Vector3.up * (turnSpeed * Time.deltaTime));
        }
    }

    private void ResetCar()
    {
        movementKeyPressed = 
            Input.GetKey(KeyCode.W) || 
            Input.GetKey(KeyCode.A) || 
            Input.GetKey(KeyCode.D) || 
            Input.GetKey(KeyCode.S);
        
        if (!movementKeyPressed && Input.GetKeyDown(KeyCode.R))
        {
            speed = 0f;
            rb.transform.position = new Vector3(0f, 0f, 165f);
            rb.rotation = Quaternion.Euler(0f, 180f, 0f);
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
    
    private void Jump()
    {
        if (rb.position.y > 0.1) return;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ball")) return;
        Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();
        Vector3 hitDirection = (collision.transform.position - transform.position).normalized;
        float force = 8f;
        ballRb.AddForce(hitDirection * force, ForceMode.Impulse);
    }
}
