using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarRightButtonScript : MonoBehaviour {


	//Variable for far left symbol
	public int symbolFR = 0;

	//Trigered when player steps on button
	void OnTriggerEnter2D (Collider2D other){
		 
		//Change to next symbol
		if (symbolFR == 4) {
			symbolFR = 1;
		} else {
			symbolFR++;
		}

		//Run function on symbol display gameobject script to match selected symbol
		switch (symbolFR) {
		case 1:
			GameObject.Find ("SymbolDisplayFR").GetComponent<SymbolChangeScript> ().changeToOne ();
			break;
		case 2:
			GameObject.Find ("SymbolDisplayFR").GetComponent<SymbolChangeScript> ().changeToTwo ();
			break;
		case 3:
			GameObject.Find ("SymbolDisplayFR").GetComponent<SymbolChangeScript> ().changeToThree ();
			break;
		case 4:
			GameObject.Find ("SymbolDisplayFR").GetComponent<SymbolChangeScript> ().changeToFour ();
			break;

		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
