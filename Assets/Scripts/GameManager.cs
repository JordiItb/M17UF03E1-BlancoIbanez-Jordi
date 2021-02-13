using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Text time;
    public Text coinScore;
    public Text score;
    private float internalScore;
    private float internalTime;
    private int internalCoinScore;
    public GameObject end;
    public GameObject controller;
    public GameObject startScreen;
    private bool paused;
    private bool finish;

    
    void Start()
    {
        paused = true;
        finish = false;
        Time.timeScale = 0f;
        internalCoinScore = 0;
    }

    
    void Update()
    {

        if(!finish){
            
            internalTime += Time.deltaTime;

            time.text = "" + ((int)internalTime).ToString();

        }        
        

        if(internalCoinScore == 6){


            endGame();

        }

        if(Input.GetKeyDown(KeyCode.Escape)){

            paused = !paused;

            if(paused){

                startGame();

            }else{

                pauseGame();

            }

        }

    }


    public void increaseCoinCount(GameObject coin){

        Destroy(coin);

        internalCoinScore++;

        coinScore.text = "x" + internalCoinScore;

    }

    void endGame(){

        end.SetActive(true);

        controller.GetComponent<MapController>().enabled = false;

        finish = true;

        setScore();

    }

    public void quit(){

        Application.Quit();

    }

    public void tryAgain(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void startGame(){

        startScreen.SetActive(false);
        Time.timeScale = 1f;

    }

    void pauseGame(){

        startScreen.SetActive(true);
        Time.timeScale = 0f;

    }

    void setScore(){

        internalScore = internalCoinScore * 5 - (internalTime / 10);

        score.text = "Score: " + ((int)internalScore).ToString();

    }

}
