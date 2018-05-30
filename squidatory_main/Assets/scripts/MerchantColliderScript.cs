using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MerchantColliderScript : MonoBehaviour {

	public GameObject canvas;

	void OnTriggerEnter (){
		//Show canvas when player enters collider
		canvas.SetActive(true);

		//Set text for dialouge value
		Text dialogueTxt = GameObject.Find ("DialogueText").GetComponent<Text>(); 
		dialogueTxt.text = "Hey, I am selling music! Would you like to buy some music for the low price of 5 coins?";

		//Set text for Button A value
		Text buttonATxt = GameObject.Find ("ButtonAText").GetComponent<Text>(); 
		buttonATxt.text = "Sure!";
		//Set text for Button B value
		Text buttonBTxt = GameObject.Find ("ButtonBText").GetComponent<Text>(); 
		buttonBTxt.text = "No thanks"; 

		//Move buttons A&B on screen (fix for SetActive = false error)
		GameObject.Find ("ButtonA").transform.position = new Vector3 (376, 131);
		GameObject.Find ("ButtonB").transform.position = new Vector3 (514, 131);
	}
		
	void OnTriggerExit (){
		//Hide canvas when player enters collider
		canvas.SetActive(false);
	}


}
