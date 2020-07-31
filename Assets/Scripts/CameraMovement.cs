using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;

    public float smoothSpeed = 10f;
    public Vector3 offset;
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position,desiredPosition,smoothSpeed*Time.deltaTime);
        transform.position = new Vector3(smoothPosition.x,smoothPosition.y,desiredPosition.z);
        transform.LookAt(player);
    }
}
