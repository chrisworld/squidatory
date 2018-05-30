using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcceptMerchantScript : MonoBehaviour {

		public void AcceptMerchant () {

		//Get number of coins collected value
		var CoinCount = GameObject.Find ("ThirdPersonController").GetComponent<CoinCountScript>();
		var coins = CoinCount.coins;

		//Move buttons A&B off screen (fix for SetActive = false error)
		GameObject.Find ("ButtonA").transform.Translate(0, -2000, 0);
		GameObject.Find ("ButtonB").transform.Translate(0, -2000, 0);

		//Check players number of coins is 5
		if (coins < 5) {
			//Player needs more coins
			Text dialogueTxt = GameObject.Find ("DialogueText").GetComponent<Text>(); 
			dialogueTxt.text = "You don't have enough coins to buy my music. Come back when you have 5 coins.";

		} else {
			//Player has enough coins
			//Set text for dialouge value
			Text dialogueTxt = GameObject.Find ("DialogueText").GetComponent<Text>(); 
			dialogueTxt.text = "Great. Here's your music. Press the M key to hear it. Also take this karma box.";

			FindObjectOfType<SoundManager> ().setBadass ();

			//Add script to add bad karma box here
		}

	}

}
