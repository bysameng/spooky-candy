using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public MainMenu menu;

	private bool isGameOver = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!isGameOver){
			InGameUpdate();
		}
	}

	void InGameUpdate(){


	}


	public void BeginGame(){
		Debug.Log("Game begin");
		isGameOver = false;
	}


	public void EndGame(){
		Debug.Log("End game!!");
		isGameOver = true;
		menu.StartMainMenu();
	}
}
