using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class contact2 : MonoBehaviour
{


    public ParticleSystem explosion;
    public float delayTime = 1f;
    public AudioSource explosionSource;

    void Start(){
        explosionSource = GetComponent<AudioSource>();
    }

    void newVoid(){
        SceneManager.LoadScene(8);
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "Present-01(Clone)" || col.gameObject.name == "Candy-Cane(Clone)"
        || col.gameObject.name == "7-Tip-Star(Clone)" || col.gameObject.name == "Santa-Hat(Clone)"
        || col.gameObject.name == "Snowflake(Clone)"){
            
            Debug.Log("Collision detected");
            Destroy(col.gameObject);

            score.instance.incrementScore();
            //score++;
            //Debug.Log($"score: {score}");
        }

        if(col.gameObject.name == "bomb(Clone)" ){
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosionSource.Play();
            Destroy(col.gameObject);
            Invoke("DelayedAction", delayTime);
            //Invoke("newVoid", 2);
            //SceneManager.LoadScene(8);
            //SceneManager.LoadScene(7);
        }

    }

    void DelayedAction(){
        SceneManager.LoadScene(8);
    }
}






