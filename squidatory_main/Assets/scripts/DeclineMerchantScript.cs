﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeclineMerchantScript : MonoBehaviour {


	public void DeclineMerchant () {



		//Set text for dialouge value
		Text dialogueTxt = GameObject.Find ("DialogueText").GetComponent<Text>(); 
		dialogueTxt.text = "Okay. Well here is your prize.";

		//Move buttons A&B off screen (fix for SetActive = false error)
		GameObject.Find ("ButtonA").transform.Translate(0, -2000, 0);
		GameObject.Find ("ButtonB").transform.Translate(0, -2000, 0);

        //Add good karma box
        GameObject.Find("2D_Box_White2").transform.Translate(-24, 0, 0);

	}
		
}
