using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float acceleration;
    [SerializeField] private float jumpForce;
    [SerializeField] private float gravity;

    private bool movementKeyPressed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        ResetCar();
        Move();
        Turn();
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
            speed -= (1.5f * acceleration) * Time.deltaTime;
        }

        if (speed <= 0)
        {
            speed += (1.5f * acceleration) * Time.deltaTime;
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
            rb.transform.position = new Vector3(10f, 0f, 0f);
            rb.rotation = Quaternion.Euler(0f, 0f, 0f);
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
