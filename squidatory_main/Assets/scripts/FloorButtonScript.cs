using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorButtonScript : MonoBehaviour {

	//Variable for symbol type
	public int symbolFL = 0;

	//Trigered when player steps on button
	void OnTriggerEnter (Collider other){
		//Moves button game object down
		this.transform.position += Vector3.down * 0.05F;

		//Change to next symbol
		if (symbolFL == 4) {
			symbolFL = 1;
		} else {
			symbolFL++;
		}

		//Run function on symbol display gameobject script to match selected symbol
		switch (symbolFL) {
		case 1:
			GameObject.Find ("SymbolDisplayFL").GetComponent<SymbolChangeScript> ().changeToOne ();
			break;
		case 2:
			GameObject.Find ("SymbolDisplayFL").GetComponent<SymbolChangeScript> ().changeToTwo ();
			break;
		case 3:
			GameObject.Find ("SymbolDisplayFL").GetComponent<SymbolChangeScript> ().changeToThree ();
			break;
		case 4:
			GameObject.Find ("SymbolDisplayFL").GetComponent<SymbolChangeScript> ().changeToFour ();
			break;

		}

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
