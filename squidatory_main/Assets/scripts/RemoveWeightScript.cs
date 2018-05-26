using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveWeightScript : MonoBehaviour {

	//Runs when object enters box collider on ground
	void OnTriggerEnter (Collider other){
		//Checks if gameobject is weight
		if (other.name == "LightWeight" ||
			other.name == "MediumWeight" || 
			other.name == "HeavyWeight")
		{
		//Destroys weight gameobject
		Destroy (other.gameObject);
		}
	}
}