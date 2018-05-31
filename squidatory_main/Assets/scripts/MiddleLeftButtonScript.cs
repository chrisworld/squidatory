using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleLeftButtonScript : MonoBehaviour {


	//Variable for far left symbol
	public int symbolML = 0;

	//Trigered when player steps on button
	void OnTriggerEnter2D (Collider2D other){
		 
		//Change to next symbol
		if (symbolML == 4) {
			symbolML = 1;
		} else {
			symbolML++;
		}

		//Run function on symbol display gameobject script to match selected symbol
		switch (symbolML) {
		case 1:
			GameObject.Find ("SymbolDisplayML").GetComponent<SymbolChangeScript> ().changeToOne ();
			break;
		case 2:
			GameObject.Find ("SymbolDisplayML").GetComponent<SymbolChangeScript> ().changeToTwo ();
			break;
		case 3:
			GameObject.Find ("SymbolDisplayML").GetComponent<SymbolChangeScript> ().changeToThree ();
			break;
		case 4:
			GameObject.Find ("SymbolDisplayML").GetComponent<SymbolChangeScript> ().changeToFour ();
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
