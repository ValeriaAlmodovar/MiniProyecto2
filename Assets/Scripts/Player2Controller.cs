using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private float speed = 20f;
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
        if(Input.GetKey(KeyCode.LeftArrow))
            horizontalInput = -1;
        if(Input.GetKey(KeyCode.RightArrow))
            horizontalInput = 1;
        if(Input.GetKey(KeyCode.UpArrow))
            forwardInput = 1;
        if(Input.GetKey(KeyCode.DownArrow))
            forwardInput = -1;

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
        
}
