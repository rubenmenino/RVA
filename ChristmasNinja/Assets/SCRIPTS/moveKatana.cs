using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveKatana : MonoBehaviour
{  
     
     void onCollisionEnter(Collision col){
        if(col.gameObject.name == "7-Tip-Star"){
            Debug.Log("Detected collision");
        } else{
            Debug.Log("Detected else collision");
        }
     }
    // Update is called once per frame  
    void Update()  
    {  
        if (Input.GetKey(KeyCode.A))  
        {  
            //Debug.Log("press A");
            transform.Translate(0.0f, 0f, 0.1f);  
        }  
        if (Input.GetKey(KeyCode.D))  
        {  
            transform.Translate(0.0f, 0f, -0.1f);   
        }  
        if (Input.GetKey(KeyCode.S))  
        {  
            transform.Translate(0.1f, 0f, 0.0f);
        }  
        if (Input.GetKey(KeyCode.W))  
        {  
            transform.Translate(-0.1f, 0f, 0.0f);  
        }  
    }  
}  
