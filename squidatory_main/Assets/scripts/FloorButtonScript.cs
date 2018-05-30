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
		this.transform.position += Vector3.up * 0.05F;

		//Get players code
		var playerFL = GameObject.Find("FloorButtonFL").GetComponentInChildren<FarLeftButtonScript>().symbolFL;
		var playerML = GameObject.Find("FloorButtonML").GetComponentInChildren<MiddleLeftButtonScript>().symbolML;
		var playerMR = GameObject.Find("FloorButtonMR").GetComponentInChildren<MiddleRightButtonScript>().symbolMR;
		var playerFR = GameObject.Find("FloorButtonFR").GetComponentInChildren<FarRightButtonScript>().symbolFR;

		//Variables for correct anwser
		var correctFL = 1;
		var correctML = 2;
		var correctMR = 3;
		var correctFR = 4;

		//Check if code has been entered correctly
		if (playerFL == correctFL &&
		    playerML == correctML &&
		    playerMR == correctMR &&
		    playerFR == correctFR) {
			Debug.Log ("It worked!");
			//Enter add good/bad box here 
		}

	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
