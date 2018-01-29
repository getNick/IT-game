using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text scoreText;
	public static int Score{ get; private set;}

	public static void  IncrementScore(){
		Score++;
	}
	public static void Reset(){
		Score = 0;
	}

	// Update is called once per frame
	public void Update () {
		scoreText.text = Score.ToString();
	}
	public static void UpdateHighScore(){
		if (Score > PlayerPrefs.GetInt("HighScore"))
		{
			PlayerPrefs.SetInt("HighScore", Score);
		}
	}
	public static int GetHighScore(){
		return PlayerPrefs.GetInt("HighScore");
	}
}
