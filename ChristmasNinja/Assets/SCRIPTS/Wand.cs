using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wand : MonoBehaviour
{
    public float speed = 1;

    private float step = 0.0015f;

    private Rigidbody rb;
    
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /*void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }*/

    void FixedUpdate()
    {
        /*Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);*/


    }

    void OnTriggerEnter(Collider other)
    {
        /*Debug.Log("");
        Debug.Log(this.transform.position);
        Debug.Log(rb.velocity);
        rb.velocity = new Vector3(0, 0, 0);
        Debug.Log(rb.velocity);*/

        //Check for a match with the specified name on any GameObject that collides with your GameObject
        /*if (other.gameObject.name == "MyGameObjectName")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Do something here");
        }*/

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (other.gameObject.CompareTag("Prop"))
        {
            //If the GameObject has the same tag as specified, output this message in the console
            //Debug.Log("garbajo");
        }
        // InnerButton
        if (other.gameObject.CompareTag("Button"))
        {
            //Debug.Log("button");
            //Debug.Log(other.gameObject.);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Do something here");
        rb.velocity = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - step;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.x = position.x + step;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.z = position.z - step;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.z = position.z + step;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 position = this.transform.position;
            position.y = position.y + step;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Vector3 position = this.transform.position;
            position.y = position.y - step;
            this.transform.position = position;
        }
    }
}
