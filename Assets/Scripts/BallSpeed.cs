using UnityEngine;

public class BallSpeed : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 0.6f);
    }
    void FixedUpdate()
    {
        float speed = rb.linearVelocity.magnitude;

        if (IsGrounded())
        {
            if (speed > 3f && speed < 0.1f)
            {
                rb.linearVelocity *= 0.9f;
            }
            if (speed <= 0.1f)
            {
                rb.linearVelocity = Vector3.zero;
            }
        }
    }
}
