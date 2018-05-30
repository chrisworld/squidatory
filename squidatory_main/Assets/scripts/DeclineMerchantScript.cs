using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeclineMerchantScript : MonoBehaviour {

	public void DeclineMerchant () {

		//Set text for dialouge value
		Text dialogueTxt = GameObject.Find ("DialogueText").GetComponent<Text>(); 
		dialogueTxt.text = "Okay. Well here is a good karama box.";

		//Disable option buttons
		GameObject.Find ("ButtonA").SetActive(false); 

		//Disable option buttons
		GameObject.Find ("ButtonB").SetActive(false);

		//Disable box collider 
		GameObject.Find ("MerchantBoxCollider").SetActive(false);


		//Add script to add good karma box here


	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
