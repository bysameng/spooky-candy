using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GameManager manager;
	public GameObject gameOverScreen;
	public GameObject aboutScreen;


	//call this function when startGame button is pressed
	public void StartGame(){
		Debug.Log("HEY YOU PRESSED THE BUTTON");
		StartGameManager();
		this.gameObject.SetActive(false);
	}

	void StartGameManager(){
		manager.BeginGame();
	}

	public void StartMainMenu(){
		gameOverScreen.gameObject.SetActive(false);
		aboutScreen.gameObject.SetActive(false);
		this.gameObject.SetActive(true);
		manager.scoreText.gameObject.SetActive(true);
	}

	public void AboutScreen(){
		aboutScreen.gameObject.SetActive(true);
		this.gameObject.SetActive(false);
		manager.scoreText.gameObject.SetActive(false);
	}

	public void StartGameOverScreen(){
		manager.gameObject.SetActive(false);
		gameOverScreen.gameObject.SetActive(true);
		var allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
		foreach(var c in allEnemies){
			if (c != null){
				Destroy(c.gameObject);
			}
		}
	}
}
