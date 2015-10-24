using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GameManager manager;


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
		this.gameObject.SetActive(true);
	}
}
