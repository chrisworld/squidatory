using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcceptMerchantScript : MonoBehaviour {

		public void AcceptMerchant () {

		//Get number of coins collected value
		var CoinCount = GameObject.Find ("ThirdPersonController").GetComponent<CoinCountScript>();
		var coins = CoinCount.coins;

		//Disable buttons A & B
		//GameObject.Find ("ButtonA").SetActive(false); 
		//GameObject.Find ("ButtonB").SetActive(false);

		//Check players number of coins is 5
		if (coins < 5) {
			//Player needs more coins
			Text dialogueTxt = GameObject.Find ("DialogueText").GetComponent<Text>(); 
			dialogueTxt.text = "You don't have enough coins to buy my music. Come back when you have 5 coins.";

		} else {
			//Player has enough coins
			//Set text for dialouge value
			Text dialogueTxt = GameObject.Find ("DialogueText").GetComponent<Text>(); 
			dialogueTxt.text = "Great. Here's your music. Also take this bad karma box.";


			//Disable box collider 
			//GameObject.Find ("MerchantBoxCollider").SetActive(false);

			//Add script to add bad karma box here
		}

	}

}
