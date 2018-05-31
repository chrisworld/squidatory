using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarLeftButtonScript : MonoBehaviour {


	//Variable for far left symbol
	public int symbolFL = 0;

	//Trigered when player steps on button
	void OnTriggerEnter2D (Collider2D other){
		 
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

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
