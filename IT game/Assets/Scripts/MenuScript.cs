using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript:MonoBehaviour{
	
	public Text HighScoreText;
	public void LoadEndScene(){
		SceneManager.LoadScene("end", LoadSceneMode.Single);
	}
	
	public void LoadMainScene()
	{
		ScoreManager.Reset();
		SceneManager.LoadScene("main", LoadSceneMode.Single);
	}
	public void Exit()
	{
		Application.Quit();
	}
	private void Update()
	{
		HighScoreText.text = "High score:"+ ScoreManager.GetHighScore().ToString();
	}
}
