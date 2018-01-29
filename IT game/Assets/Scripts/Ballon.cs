using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Ballon : MonoBehaviour {
	private float speed;
	private void Start()
	{
		speed = Random.Range(1.0f, 3.5f);
	}
	void Update() {
		if (speed < 3){ 
			speed += 0.005f * Mathf.Pow(speed, 2);
		}
		transform.position += Vector3.up * speed * Time.deltaTime;
		if(transform.position.y>5){
			ScoreManager.UpdateHighScore();
			SceneManager.LoadScene("end", LoadSceneMode.Single);
		}
	}
	public void Explore(){

		ScoreManager.IncrementScore();
		
	}
}
