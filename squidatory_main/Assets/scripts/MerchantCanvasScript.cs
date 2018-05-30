using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantCanvasScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		//Hide canvas on inital load
		this.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		var test = GameObject.Find ("ThirdPersonController").GetComponent<CoinCountScript>();
		var coins = test.coins;
	}
}
