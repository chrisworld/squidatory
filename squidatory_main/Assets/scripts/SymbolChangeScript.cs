﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolChangeScript : MonoBehaviour {
	//Functions to change material of symbol screen to match current symbol
	public void changeToOne (){
		GetComponent<Renderer>().material.color = new Color32(20,138,203,1); //STILL TO DO - Change this value to new symbol
	}

	public void changeToTwo (){
		GetComponent<Renderer>().material.color = new Color32(252,240,87,1); //STILL TO DO - Change this value to new symbol
	}

	public void changeToThree (){
		GetComponent<Renderer>().material.color = new Color32(237,32,39,1); //STILL TO DO - Change this value to new symbol
	}

	public void changeToFour (){
		GetComponent<Renderer>().material.color = new Color32(246,139,33,1); //STILL TO DO - Change this value to new symbol
		//Color.yellow;
	}

}
