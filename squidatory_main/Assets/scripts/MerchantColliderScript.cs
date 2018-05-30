using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MerchantColliderScript : MonoBehaviour {

	public GameObject canvas;

	void OnTriggerEnter (){
		//Show canvas when player enters collider
		canvas.SetActive(true);

		//Get number of coins collected value
		var CoinCount = GameObject.Find ("ThirdPersonController").GetComponent<CoinCountScript>();
		var coins = CoinCount.coins;

		//Set text for dialouge value
		Text dialogueTxt = GameObject.Find ("DialogueText").GetComponent<Text>(); 
		dialogueTxt.text = "Hey, I am selling music! Would you like to buy some music for the low price of 5 coins?";

		//Set text for Button A value
		Text buttonATxt = GameObject.Find ("ButtonAText").GetComponent<Text>(); 
		buttonATxt.text = "Sure!";
		//Set text for Button A value
		Text buttonBTxt = GameObject.Find ("ButtonBText").GetComponent<Text>(); 
		buttonBTxt.text = "No thanks";


		//Set text in dialogue box 
		if (coins < 5) {
			
		} else {
			Debug.Log ("Great!");
		}
	
	}
		
	void OnTriggerExit (){
		//Hide canvas when player enters collider
		canvas.SetActive(false);
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
