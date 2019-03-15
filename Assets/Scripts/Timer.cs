using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
  public int timeLeft = 60; //Seconds Overall
  public Text countdown; //UI Text Object
  public int highscore;
  public ScoreCounter currentscore;
  //public sceneChange newscene;
  void Start () {
    StartCoroutine("LoseTime");
    Time.timeScale = 1; //Just making sure that the timeScale is right
  }
  void Update () {
    countdown.text = ("" + timeLeft); //Showing the Score on the Canvas
    if(timeLeft <= 0){
      //newscene.changeScene("GameOver");
      SceneManager.LoadScene("GameOver");
      highscore = currentscore.score;
      PlayerPrefs.SetInt("High Score", highscore);
    }
  }
  //Simple Coroutine
  IEnumerator LoseTime()
  {
    while (true) {
      yield return new WaitForSeconds (1);
      timeLeft--; 
    }
    
  }
}