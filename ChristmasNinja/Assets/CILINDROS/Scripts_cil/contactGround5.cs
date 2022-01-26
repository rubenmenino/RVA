using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class contactGround5 : MonoBehaviour
{
    
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
