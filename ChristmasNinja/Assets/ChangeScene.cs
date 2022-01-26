using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void restartGame1(){
        SceneManager.LoadScene(PlayerPrefs.GetInt("LVL1"));
        SceneManager.LoadScene("LVL1");   
    }

    public void restartGame2(){
        SceneManager.LoadScene(PlayerPrefs.GetInt("LVL2"));
        SceneManager.LoadScene("LVL2");
    }

    public void restartGame3(){
        SceneManager.LoadScene(PlayerPrefs.GetInt("LVL3"));
        SceneManager.LoadScene("LVL3");
    }

    public void restartGame4(){
        SceneManager.LoadScene(PlayerPrefs.GetInt("LVL4"));
        SceneManager.LoadScene("LVL4");
    }

    public void restartGame5(){
        SceneManager.LoadScene(PlayerPrefs.GetInt("LVL5"));
        SceneManager.LoadScene("LVL5");
    }

    public void menu(){
        SceneManager.LoadScene(1);
    }

    public void menuCilindros(){
        SceneManager.LoadScene(14);
    }

    public void menuRefelx(){
        SceneManager.LoadScene(18);
    }
}
