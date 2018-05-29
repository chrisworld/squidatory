using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolChangeScript : MonoBehaviour {

	public void changeToOne (){
		Debug.Log ("It worked!");
		GetComponent<Renderer>().material.color = Color.black;
	}

	public void changeToTwo (){
		Debug.Log ("It worked!");
		GetComponent<Renderer>().material.color = Color.red;
	}

	public void changeToThree (){
		Debug.Log ("It worked!");
		GetComponent<Renderer>().material.color = Color.blue;
	}

	public void changeToFour (){
		Debug.Log ("It worked!");
		GetComponent<Renderer>().material.color = Color.yellow;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
