using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolChangeScript : MonoBehaviour {
	//Functions to change material of symbol screen to match current symbol
	public void changeToOne (){
		GetComponent<Renderer>().material.color = Color.black; //STILL TO DO - Change this value to new symbol
	}

	public void changeToTwo (){
		GetComponent<Renderer>().material.color = Color.red; //STILL TO DO - Change this value to new symbol
	}

	public void changeToThree (){
		GetComponent<Renderer>().material.color = Color.blue; //STILL TO DO - Change this value to new symbol
	}

	public void changeToFour (){
		GetComponent<Renderer>().material.color = Color.yellow; //STILL TO DO - Change this value to new symbol
	}

}
