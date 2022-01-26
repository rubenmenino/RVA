using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public static score instance;

    public Text scoreText;
    public Text highscoreText;

    public int scoree = 0;
    int highscore = 0;
    
    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = scoree.ToString() + " points";
        highscoreText.text = "Highscore: " + highscore.ToString();
        //PlayerPrefs.SetInt(SceneManager.GetActiveScene().name, scoree);

        
    }

    // Update is called once per frame
    public void incrementScore()
    {
        
        scoree = scoree + 1;
        scoreText.text = scoree.ToString() + " points";
        if(highscore < scoree){
            PlayerPrefs.SetInt("highscore", scoree); // Sets a single integer value for the preference identified by the given key. You can use PlayerPrefs.GetInt to retrieve this value.
            
        }
        scoree = Mathf.Max(0, scoree);
        if(scoree <= 0){
            scoree = 0;
        }
        /* // if(scoree == 0){
        //     Time.timeScale = 0;
        //     scoreText.text = scoree.ToString() + " points. Game over";
        // } */
    }

    // Update is called once per frame
    public void decrementScore()
    {
        if(scoree != 0 && scoree > 0){
            scoree = scoree - 1;
            scoreText.text = scoree.ToString() + " points";
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name, scoree);
        }

        if(scoree == 0){
            SceneManager.LoadScene(7);
        }

        
        /* if(scoree == 0){
            Time.timeScale = 0;
            scoreText.text = scoree.ToString() + " points. Game over";
        } */
        //scoree = Mathf.Max(0, scoree);
        //if(scoree <= 0){
        //    scoree = 0;
        //}
    }

    public void gameOver(){
        if(scoree == 0){
            Application.Quit();
        }
    }


}
