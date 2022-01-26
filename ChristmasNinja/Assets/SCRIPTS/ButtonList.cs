using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ButtonList : MonoBehaviour
{
    public Material green;
    public Material black;
    public Material red;

    GameObject getRandomButton() {
        int idx = Random.Range(0, gameObject.transform.childCount );

        return gameObject.transform.GetChild(idx).GetChild(0).gameObject;
    }

    public void activateNextButton() {

        //print("Starting " + Time.time);
        
        int red_chance = Random.Range(0, 100);

        if(red_chance <= 20) {
            StartCoroutine(TurnRed(2.0f));
        } else {
            StartCoroutine(TurnGreen(2.0f));
        }

        //print("Before TurnGreen Finishes " + Time.time);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator TurnRed(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Button button = getRandomButton().GetComponent<Button>();
        button.changeColor("Red");

        yield return new WaitForSeconds(waitTime);
        button.changeColor("Black");
        GameManager.Instance.setAllButtonsOff(true);
    }

    private IEnumerator TurnGreen(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Button button = getRandomButton().GetComponent<Button>();
        button.changeColor("Green");

        GameManager.Instance.setGreenUp();
    }
}
