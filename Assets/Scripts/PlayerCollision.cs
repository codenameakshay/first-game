using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
public class PlayerCollision : MonoBehaviour
{
    public PlyerMovement playerMovement;
    public GameObject cameraFX;
    public int health = 3;
    ColorGrading colorGradingLayer = null;
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Obstacle")
        {
            if (health == 1)
            {
                playerMovement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }
            else if (health != 1)
            {
                health = health - 1;

            }
            PostProcessVolume volume = cameraFX.GetComponent<PostProcessVolume>();
            volume.profile.TryGetSettings(out colorGradingLayer);
            colorGradingLayer.enabled.value = true;
            float originalRed = colorGradingLayer.mixerRedOutRedIn.value;
            colorGradingLayer.mixerRedOutRedIn.value = originalRed + 50f;
            Debug.Log(health);
        }

    }
}
