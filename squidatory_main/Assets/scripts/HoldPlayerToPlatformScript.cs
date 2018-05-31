using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldPlayerToPlatformScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		//Make moving platform parent of game object when game object collides with platform
		col.transform.parent = gameObject.transform;
	}

	void OnTriggerExit2D(Collider2D col){
		//Detaches game object from platform when game object exits platform
		col.transform.parent = null;
	}
}
