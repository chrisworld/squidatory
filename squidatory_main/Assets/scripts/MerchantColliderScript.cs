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

		if (coins < 5) {
			Debug.Log ("You need more coins");
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
