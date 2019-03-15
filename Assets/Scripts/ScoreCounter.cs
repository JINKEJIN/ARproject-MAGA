using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

    public Text scoreText;
    public int score;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    public void Onclick () {

        scoreText.text = ""+ score;
        score++;

        //if (Input.GetMouseButtonDown(0))
        //{
            //score++;
        //}
    }
}