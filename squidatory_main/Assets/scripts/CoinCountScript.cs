using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCountScript : MonoBehaviour {
	//Sets variable for coin counting
	public int coins = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnGUI(){
		//Show number of coins collected on GUI
		GUI.Label (new Rect (10, 10, 150, 50), "Coins: " + coins);
	}
}
