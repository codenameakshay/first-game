using UnityEngine;

public class PlyerMovement : MonoBehaviour {
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate () {
        rb.AddForce (0, 0, 500 * Time.deltaTime);
    }
}