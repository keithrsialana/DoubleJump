using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody body;
    private float jumpForce;
    private float gravity;

    private void Awake()
    {
        gravity = 9.81f;
        jumpForce = 100f;
        body = GetComponent<Rigidbody>();
        body.maxLinearVelocity = 9.8f;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
            body.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        else
        {
            body.AddForce(Vector3.down * gravity, ForceMode.Force);
        }
    }
}
