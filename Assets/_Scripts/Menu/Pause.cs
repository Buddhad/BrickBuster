using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField]GameObject pauseMenu;
    
    public void Pausemenu()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        //quitDialog.SetActive(true);
    }

    public void LevelScene()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    public void YesExit()
    {
        Application.Quit();
    }
    public void NoExit()
    {
        //quitDialog.SetActive(false);
    }
    

    public void AudioMenu()
    {
        //audioMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
