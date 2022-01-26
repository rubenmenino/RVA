using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class throwObjects4 : MonoBehaviour
{

    //public sliderController valueSlider;
    public GameObject[] christmasObjects;
    private IEnumerator coroutine;
    Vector3 myVector;
    public Text countDownText;
    float yyy = 0f;
    public float velocity = 0.9f;
    public bool gamePlaying {get; private set;}
    public int countDownTime;



    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 0f;
        //velocity = 0.5f;
        gamePlaying = false;
        StartCoroutine(CountDownToStart());
        coroutine = throwObj(velocity);
        StartCoroutine(coroutine);

        
    }
    

    IEnumerator throwObj(float waitTime){
        //Debug.Log("throwObj created");
        while(countDownTime == 0 ){

            GameObject omegalul = Instantiate(christmasObjects[Random.Range(0, 6)]);
            Rigidbody omega = omegalul.GetComponent<Rigidbody>();

            omega.angularVelocity = new Vector3(Random.Range(-5f,5f), yyy, Random.Range(-5f,5f));
            omega.velocity = new Vector3(-4f, 12f, .5f);
            
            var tmp =  transform.position;
            tmp.x = tmp.x + Random.Range(-1f, 1f);
            tmp.z = tmp.z + Random.Range(-5f, 5f);
            omegalul.transform.position = tmp;

            // Yield execution of this coroutine and return to the main loop until next frame
            yield return new WaitForSeconds(waitTime);
            //yield return new WaitForSecondsRealtime(3);
        }
    }

   // public void AdjustVelocity(float newVelocity){
    //    velocity = valueSlider.sliderValue;
    //}

    private void BeginGame(){
        gamePlaying = true;
        //startTime = Time.time;
        //Invoke("ShowGameOverScreen", 1.25f);
    }

    private void EndGame(){
        gamePlaying = false;
        //Invoke("ShowGameOverScreen", 1.25f);
    }

    IEnumerator CountDownToStart(){
        while(countDownTime > 0){
            countDownText.text = countDownTime.ToString();
            yield return new WaitForSeconds(1f);
            countDownTime = countDownTime - 1;
            if(countDownTime == 0){
                countDownTime = 0;
            }
        }
        countDownTime = 0;
        BeginGame();
        countDownText.text = " ";
        yield return new WaitForSecondsRealtime(1f);
        countDownText.gameObject.SetActive(false);
        yield return StartCoroutine(throwObj(velocity));
        
    }


    
}
