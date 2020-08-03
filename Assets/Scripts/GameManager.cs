using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject completeLevelUI;
    public float restartTime;
    void Start(){
    Application.targetFrameRate = 120;
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game OVER!!!");
            Invoke("Restart", restartTime);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
