using UnityEngine;
using System.Collections;

public class TouchManager : MonoBehaviour {

	ParticleController c;

	public AudioClip kid;
	public AudioClip monster;


	void Awake(){
		c = GetComponentInChildren<ParticleController>();
	}


	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)){
			Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit info;
			bool hit = Physics.Raycast(r, out info);

			if (hit){
				Enemy e = info.collider.GetComponent<Enemy>();
				if (e != null){
					c.PlayParticles(info.point);
					e.OnTap();
					if (e.isKid){
						AudioSource.PlayClipAtPoint(kid, transform.position);
					}
					else{
						AudioSource.PlayClipAtPoint(monster, transform.position);
					}
				}
			}
		}
	
	}
}
