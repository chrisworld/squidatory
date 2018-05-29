using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleRightButtonScript : MonoBehaviour {


	//Variable for far left symbol
	public int symbolMR = 0;

	//Trigered when player steps on button
	void OnTriggerEnter (Collider other){
		 
		//Change to next symbol
		if (symbolMR == 4) {
			symbolMR = 1;
		} else {
			symbolMR++;
		}

		//Run function on symbol display gameobject script to match selected symbol
		switch (symbolMR) {
		case 1:
			GameObject.Find ("SymbolDisplayMR").GetComponent<SymbolChangeScript> ().changeToOne ();
			break;
		case 2:
			GameObject.Find ("SymbolDisplayMR").GetComponent<SymbolChangeScript> ().changeToTwo ();
			break;
		case 3:
			GameObject.Find ("SymbolDisplayMR").GetComponent<SymbolChangeScript> ().changeToThree ();
			break;
		case 4:
			GameObject.Find ("SymbolDisplayMR").GetComponent<SymbolChangeScript> ().changeToFour ();
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
