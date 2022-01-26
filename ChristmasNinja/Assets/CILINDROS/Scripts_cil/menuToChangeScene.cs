using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuToChangeScene : MonoBehaviour
{
    public void cilindrosLvl1(){
        SceneManager.LoadScene(9);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void cilindrosLvl2(){
        SceneManager.LoadScene(10);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void cilindrosLvl3(){
        SceneManager.LoadScene(11);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void cilindrosLvl4(){
        SceneManager.LoadScene(12);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void cilindrosLvl5(){
        SceneManager.LoadScene(13);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void TutorialCilindroGame(){
        //SceneManager.LoadScene(6);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void menucilindros(){
        SceneManager.LoadScene(14);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void tutorialcilindros(){
        SceneManager.LoadScene(15);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void QuitCilindrosGame(){
        Application.Quit();
    }
}
