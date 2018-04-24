using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldPlayerToPlatformScript : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		//Make moving platform parent of game object when game object collides with platform
		col.transform.parent = gameObject.transform;
	}

	void OnTriggerExit(Collider col){
		//Detaches game object from platform when game object exits platform
		col.transform.parent = null;
	}
}
