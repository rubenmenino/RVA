using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayNinjaGame(){
        PlayerPrefs.SetInt("LVL1", SceneManager.GetActiveScene().buildIndex);
        
        SceneManager.LoadScene(2);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void PlayLVL1(){
        PlayerPrefs.SetInt("LVL1", SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene("1");
        SceneManager.LoadScene(2);
    }

    public void PlayLVL2(){
        PlayerPrefs.SetInt("LVL2", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(3);
    }

    public void PlayLVL3(){
        PlayerPrefs.SetInt("LVL3", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(4);
    }

    public void PlayLVL4(){
        PlayerPrefs.SetInt("LVL4", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(5);
    }

    public void PlayLVL5(){
        PlayerPrefs.SetInt("LVL5", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(6);
    }

    public void TutorialNinjaGame(){
        SceneManager.LoadScene(7);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void menuChristmas(){
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void menuCILINDROS(){
        SceneManager.LoadScene(14);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }


    public void menuGames(){
        SceneManager.LoadScene(0);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void menuReflex(){
        SceneManager.LoadScene(18);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void tutorialReflex(){
        SceneManager.LoadScene(19);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void startGameReflex(){
        SceneManager.LoadScene(17);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void QuitNinjaGame(){
        Application.Quit();
    }

    
}
