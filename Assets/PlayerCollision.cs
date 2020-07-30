using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {
        Debug.Log("Hello");
    }
}
