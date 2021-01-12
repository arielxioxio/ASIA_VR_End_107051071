using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public void RestartGame()
    {
        SceneManager.LoadScene("沙包");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
