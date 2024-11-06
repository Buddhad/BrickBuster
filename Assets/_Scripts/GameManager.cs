using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int score;
    public int numberOfBricks;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI liveText;
    //public TextMeshProUGUI hightScore;
    public bool gameOver;
    public bool winGame;
    public GameObject gameOverPannel;
    public GameObject gameWinPannel;

    private void Start() {
        liveText.text="Lives: "+lives;
        scoreText.text="Score: "+score;
        numberOfBricks=GameObject.FindGameObjectsWithTag("Brick").Length;
    }

    public void UpdateLives(int changeInLive){
        lives+=changeInLive;
        if(lives<=0){
        lives=0;
        GameOver();
        //Check the no lives left and trigger the end game screen
        Debug.Log("Game Over");
        }
        
        liveText.text="Lives: "+lives;
    }
    public void UpdateNumberOfBricks(){
        numberOfBricks--;
        if(numberOfBricks<=0){
            Win();
        }
    }

    public void UpdateScore(int points){
        score+= points;
        scoreText.text="Score: "+score;
    }

    public void GameOver(){
        gameOver=true;
        gameOverPannel.SetActive(true);
    }
    public void Win(){
        winGame=true;
        gameWinPannel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}

