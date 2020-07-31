using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Levels");
    }
    public void ShowCredits()
    {
        SceneManager.LoadScene(("Credits"));
    }
}
