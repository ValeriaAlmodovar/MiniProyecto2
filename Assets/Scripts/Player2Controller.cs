using UnityEngine;

public class Player2Controller : MonoBehaviour
{
<<<<<<< Updated upstream
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float jumpSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
=======
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed;
>>>>>>> Stashed changes

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
        Turn();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.transform.Translate(Vector3.back * (speed * Time.deltaTime));
        }
    }

    private void Turn()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.Rotate(Vector3.down * (turnSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.transform.Rotate(Vector3.up * (turnSpeed * Time.deltaTime));
        }
    }
}