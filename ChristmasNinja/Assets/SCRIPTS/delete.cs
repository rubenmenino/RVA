using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    /*
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag.Equals("DestrucCol")){
            Destroy(collision.gameObject);
        }
    }
    */

    void Update()
    {
        /*
        if(gameObject.name == "Scimitar w_ Colliders"){
            Debug.Log("Collision detected");
        }
        */
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 5);
    }
    

}
