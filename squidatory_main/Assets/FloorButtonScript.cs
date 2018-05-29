using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorButtonScript : MonoBehaviour {

	//Variable for symbol type
	public int symbol = 0;

	//Trigered when player steps on button
	void OnTriggerEnter (Collider other){
		//Moves button game object down

		if (test == 4){
			test = 1;
		} else {
			test++;
		}
		Debug.Log ("Test is: " + test);
	}

	//Trigered when player steps off button
	void OnTriggerExit (Collider other){
		
		Debug.Log ("Object has exited");
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
