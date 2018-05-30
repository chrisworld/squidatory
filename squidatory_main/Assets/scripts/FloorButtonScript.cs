using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorButtonScript : MonoBehaviour {

	//Trigered when player steps on button
	void OnTriggerEnter (Collider other){
		//Moves button game object down
		this.transform.position += Vector3.down * 0.05F;

		//Play button sound	
		FindObjectOfType<SoundManager>().Play("button");

	}

	//Trigered when player steps off button
	void OnTriggerExit (Collider other){
		//Moves button game object up 
		//Moves button game object down
		this.transform.position += Vector3.up * 0.05F;
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
