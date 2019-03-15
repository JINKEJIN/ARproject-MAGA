using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScore : MonoBehaviour {

	public Text scoreText;
	public int score;
	//public Timer gameover;

	// Use this for initialization
	void Start () {

		score = PlayerPrefs.GetInt("High Score", 0);
		scoreText.text = score.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
