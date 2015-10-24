using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public GameManager manager;

	public Sprite[] monsterSprites;
	public Sprite[] kidSprites;

	public bool isKid = false;

	private SpriteRenderer render;

	void Awake(){
		render = GetComponentInChildren<SpriteRenderer>();
	}

	void Start(){

		if (Random.value > .5f){
			isKid = true;
			this.gameObject.name = "kid";
		}
		else{
			isKid = false;
			this.gameObject.name = "monster";
		}

		if (isKid){
			//this is a kid, use a kid sprite
			Sprite randomKidSprite = kidSprites[Random.Range(0, kidSprites.Length)];
			render.sprite = randomKidSprite;
		}
		else{
			//this is a monster, use a monster sprite
			Sprite randomMonsterSprite = monsterSprites[Random.Range(0, monsterSprites.Length)];
			render.sprite = randomMonsterSprite;
		}
	}


	void Update(){
		if (transform.position.x > 10){
			if (!isKid){
				manager.EndGame();
			}
			Destroy(this.gameObject);
		}
	}

	public void OnTap(){
		if (isKid){
			manager.EndGame();
		}
		manager.AddScore(100);
		Destroy(this.gameObject);
	}



}
