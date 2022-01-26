using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class contactGround : MonoBehaviour
{

    /*
    void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "Cylinder" && col.gameObject.name == "Cylinder (1)"
        && col.gameObject.name == "Cylinder (2)" && col.gameObject.name == "Cylinder (3)"
        && col.gameObject.name == "Cylinder (4)" && col.gameObject.name == "Cylinder (5)"
        && col.gameObject.name == "Cylinder (6)" && col.gameObject.name == "Cylinder (7)"
        && col.gameObject.name == "Cylinder (8)" && col.gameObject.name == "Cylinder (9)"){
            
            Debug.Log("Collision detected");
            //fallSound.Play();
            SceneManager.LoadScene(16);
            //Destroy(col.gameObject);
        }
        
    } 
    */
    private HashSet<GameObject> collided = new HashSet<GameObject>();

    void OnCollisionEnter(Collision col){
        if(col.gameObject.name.StartsWith("Cylinder") && !collided.Contains(col.gameObject)){
            Debug.Log("Collision detected");
            collided.Add(col.gameObject);

            if(collided.Count >= 10){
                SceneManager.LoadScene(16); 
            } 
        }
    }




    








}
