using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float playerSpeed = 3.0f;

	// Use this for initialization
	void Start ()
    {
       transform.position = new Vector3(-12, 0, 0);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += (transform.forward * playerSpeed * Time.deltaTime);
	}
}
