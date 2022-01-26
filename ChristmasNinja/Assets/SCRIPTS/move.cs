using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Vector3 startPos_cylinder;
    public Transform transform_cylinder;

    private void Awake(){
        startPos_cylinder = transform_cylinder.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveLeftRight(){
        Vector3 vec_left = Vector3.zero;
        vec_left.x = Input.GetAxis("Horizontal");
    }
}
