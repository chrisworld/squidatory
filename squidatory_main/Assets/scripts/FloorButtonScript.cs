using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorButtonScript : MonoBehaviour {

	//Variable for symbol type
	public int symbol = 0;

	//Trigered when player steps on button
	void OnTriggerEnter (Collider other){
		//Moves button game object down
		this.transform.position += Vector3.down * 0.05F;

		//Change to next symbol
		if (symbol == 4){
			symbol = 1;
		} else {
			symbol++;
		}

		Debug.Log ("Test is: " + symbol);
	}

	//Trigered when player steps off button
	void OnTriggerExit (Collider other){
		//Moves button game object up 
		//Moves button game object down
		this.transform.position += Vector3.up * 0.05F;

		Debug.Log ("Object has exited");
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
