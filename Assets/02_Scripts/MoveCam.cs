using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public GameObject camera;
    public float moveSpeed;
    void Update()
    {
        ControllingCam();
    }

    public void ControllingCam()
    {
        Vector3 move = new Vector3();
        
        if (Input.GetKey(KeyCode.W)) move.y += 1;
        if (Input.GetKey(KeyCode.D)) move.y += 1;
        if (Input.GetKey(KeyCode.S)) move.y -= 1;
        if (Input.GetKey(KeyCode.A)) move.y -= 1;

        camera.transform.position += move * (moveSpeed * Time.deltaTime);
    }
}
