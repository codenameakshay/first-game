using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public Rigidbody player;
    public Text speedText;
    // Update is called once per frame
    void Update()
    {
        speedText.text = player.velocity.z.ToString("0") + " m/s";
    }
}
