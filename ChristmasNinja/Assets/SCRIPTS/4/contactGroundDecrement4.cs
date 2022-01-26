using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class contactGroundDecrement4 : MonoBehaviour
{
    public AudioSource fallSound;
    public AudioSource gameOver;

    void Start(){
        fallSound = GetComponent<AudioSource>();
        gameOver = GetComponent<AudioSource>();
    }

    

    void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "Present-01(Clone)" || col.gameObject.name == "Candy-Cane(Clone)"
        || col.gameObject.name == "7-Tip-Star(Clone)" || col.gameObject.name == "Santa-Hat(Clone)"
        || col.gameObject.name == "Snowflake(Clone)"){
            
            Debug.Log("Collision detected");
            //fallSound.Play();
            SceneManager.LoadScene(8);
            Destroy(col.gameObject);

            //score.instance.decrementScore();
            //score++;
            //Debug.Log($"score: {score}");

            //if(score.instance.scoree == 0){
            //    gameOver.Play();
            //    score.instance.gameOver();
            //}      
        }
        
        if(col.gameObject.name == "bomb(Clone)" ){
            
            //Destroy (col.gameObject, 1);
            Destroy(col.gameObject);   
            
        }
        
    }
}
