using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public MainMenu menu;

	public AudioSource gameOverSound;

	private bool isGameOver = true;

	public float score = 0;
	public Text scoreText;


	public void AddScore(float score){
		this.score += score;
		this.scoreText.text = "SCORE: " + ((int)this.score);
	}


	// Update is called once per frame
	void Update () {
		if (!isGameOver){
			InGameUpdate();
		}
	}

	void InGameUpdate(){
		AddScore(Time.deltaTime*10f);
	}


	public void BeginGame(){
		Debug.Log("Game begin");
		this.gameObject.SetActive(true);
		isGameOver = false;
		score = 0;
		AddScore(0);
	}


	public void EndGame(){
		Debug.Log("End game!!");
		this.gameObject.SetActive(false);
		isGameOver = true;
		menu.StartGameOverScreen();
		gameOverSound.Play();
	}
}
