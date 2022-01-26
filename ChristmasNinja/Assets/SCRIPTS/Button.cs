using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public Material green;
    public Material black;
    public Material red;

    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //green = Resources.Load<Material>("GreenInnerButton");
        //black = Resources.Load<Material>("OffInnerButton");
        
        meshRenderer = GetComponent<MeshRenderer>();

        // Get the current material applied on the GameObject
        // meshRenderer.material;

        //Debug.Log("Applied Material: " + current.name.ToString().Split(' ')[0]  );

        // Set the new material on the GameObject
        //meshRenderer.material = SphereMaterial;
    }

    void OnTriggerEnter(Collider other)
    {
        if (meshRenderer.material.name.ToString().Split(' ')[0] == green.name) {
            //Debug.Log("green");
            changeColor("Black");
            GameManager.Instance.setGreenDown();

            GameManager.Instance.setAllButtonsOff(true);
        } else if (meshRenderer.material.name.ToString().Split(' ')[0] == red.name) {
            //GameManager.Instance.setGameOver();
            SceneManager.LoadScene(20);
        }
    }

    public void changeColor(string color) {
        switch (color)
        {
            case "Black":
                meshRenderer.material = black;
                break;

            case "Red":
                meshRenderer.material = red;
                break;

            case "Green":
                meshRenderer.material = green;
                break;

            default:
                meshRenderer.material = black;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
