using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public int lives;
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI liveText;
    public bool gameOver;

    private void Start() {
        liveText.text="Lives: "+lives;
        scoreText.text="Score: "+score;
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

    public void UpdateScore(int points){
        score+= points;
        scoreText.text="Score: "+score;
    }

    public void GameOver(){
        gameOver=true;
    }
}

