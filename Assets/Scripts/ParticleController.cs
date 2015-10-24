using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour {


	ParticleSystem s;

	void Awake(){
		s = GetComponent<ParticleSystem>();
	}

	public void PlayParticles(Vector3 position){
		transform.position = position;	
		s.Emit(50);
	}

}
