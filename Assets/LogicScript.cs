using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreen; 

    [ContextMenu("IncreaseScore")] 
    public void addScore(int scoretoAdd)
    {
        playerScore = playerScore + scoretoAdd;
        scoreText.text = playerScore.ToString();

    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true); 
    }


}