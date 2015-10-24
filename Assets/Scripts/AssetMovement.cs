using UnityEngine;
using System.Collections;

public class AssetMovement : MonoBehaviour {

    public float playerSpeed = 3.0f;

	// Update is called once per frame
	void Update (){
        transform.position += (transform.right * playerSpeed * Time.deltaTime);
	}
}
