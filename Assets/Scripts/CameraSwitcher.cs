using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    public GameObject cameraView1P1;
    public GameObject cameraView2p1;

    public GameObject cameraView1P2;
    public GameObject cameraView2P2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cameraView1P1.SetActive(!cameraView1P1.activeSelf);
            cameraView2p1.SetActive(!cameraView2p1.activeSelf);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            cameraView1P2.SetActive(!cameraView1P2.activeSelf);
            cameraView2P2.SetActive(!cameraView2P2.activeSelf);
        }
    }

    void LateUpdate()
    {

    }
}