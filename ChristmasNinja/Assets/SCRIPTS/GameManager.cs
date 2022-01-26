using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool allButtonsOff = true;
    private float greenTimestamp = 0;
    private bool gameOver = false;
    private int greenCnt = 0;

    public ButtonList buttonlist;

    public Text t1;
    private float timeSum = 0;

    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }

    public void setAllButtonsOff(bool value) {
        allButtonsOff = value;
    }

    public void setGreenUp() {
        greenTimestamp = Time.time;
    }

    public void setGreenDown() {
        Debug.Log("Reaction time: " + (Time.time - greenTimestamp));
        timeSum += Time.time - greenTimestamp;
        t1.text = "Reaction Time:\n" + timeSum;
        greenCnt++;
    }

    public void setGameOver() {
        t1.text = "Failed";
        gameOver = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        t1.text = "Reaction Time:\n";
    }

    // Update is called once per frame
    void Update()
    {
        if (greenCnt == 10) {
            t1.text = "Congrats! Score:\n" + timeSum;
            gameOver = true;
            SceneManager.LoadScene(21);
        }
        else if (allButtonsOff && !gameOver) {
            allButtonsOff = false;
            buttonlist.activateNextButton();
        }
    }

}
