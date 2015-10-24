using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	GameManager manager;

	float timer = 1;
	public float timerFullValue = .6f;

	float fixedXSpawnLocation = -12;

	public GameObject enemyPrefab;

	// Use this for initialization
	void Awake () {
		manager = GetComponent<GameManager>();
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
		Random.seed = (int)(Time.deltaTime * Random.value * 10000);
		float ySpawnPosition = Random.Range(-3f, 3f);
		Vector3 spawnPosition = new Vector3(fixedXSpawnLocation, ySpawnPosition, 0);
		GameObject.Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
		Enemy e = enemyPrefab.GetComponent<Enemy>();
		e.manager = manager;
		e.GetComponent<AssetMovement>().playerSpeed = Random.Range(5f, 15f);
	}


	void TickDownTimer(){
		timer -= Time.deltaTime;
		timerFullValue -= (Time.deltaTime / 22f);
		timerFullValue = Mathf.Clamp(timerFullValue, .01f, 1f);
	}


	bool IsTimerComplete(){
		return (timer < 0);
	}


	void ResetTimer(){
		timer = timerFullValue;
	}
}
