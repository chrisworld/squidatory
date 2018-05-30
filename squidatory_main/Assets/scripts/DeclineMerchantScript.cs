using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeclineMerchantScript : MonoBehaviour {


	public void DeclineMerchant () {



		//Set text for dialouge value
		Text dialogueTxt = GameObject.Find ("DialogueText").GetComponent<Text>(); 
		dialogueTxt.text = "Okay. Well here is a good karama box.";



		//GameObject.Find ("ButtonA").SetActive(false); 
		//GameObject.Find ("ButtonB").SetActive(false);

		//Disable box collider 
		//GameObject.Find ("MerchantBoxCollider").SetActive(false);



		//Add script to add good karma box here


	}
		
}
