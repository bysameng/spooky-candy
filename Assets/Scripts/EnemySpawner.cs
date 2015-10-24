using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	float timer = 0;
	float timerFullValue = 1f;

	float fixedXSpawnLocation = -12;

	public GameObject enemyPrefab;

	// Use this for initialization
	void Start () {

	}


	void Update () {
		TickDownTimer();
		if (IsTimerComplete()){
			SpawnNewEnemy();
			ResetTimer();
		}
	}



	void SpawnNewEnemy(){
		//spawn here
		float ySpawnPosition = Random.Range(-5f, 5f);
		Vector3 spawnPosition = new Vector3(fixedXSpawnLocation, ySpawnPosition, 0);
		Quaternion spawnRotation = Quaternion.Euler(0f, 90f, 0f);
		GameObject.Instantiate(enemyPrefab, spawnPosition, spawnRotation);
	}


	void TickDownTimer(){
		timer -= Time.deltaTime;
	}


	bool IsTimerComplete(){
		return (timer < 0);
	}


	void ResetTimer(){
		timer = timerFullValue;
	}
}
