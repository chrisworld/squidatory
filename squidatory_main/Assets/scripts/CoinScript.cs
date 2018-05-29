using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other){
		//Trigger when player object collides with coin
		if (other.name == "ThirdPersonController") {
			Destroy (gameObject); //Remove coin game object from scene
			other.GetComponent<CoinCountScript>().coins++; //Increment coin variable in coin count script
			FindObjectOfType<SoundManager>().Play("coin");
		}
	}
}
