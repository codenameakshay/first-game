using UnityEngine;

public class PlyerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float horizontalForce = 1000f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 2 * horizontalForce * Time.deltaTime, 0,ForceMode.VelocityChange);
        }
    }
}