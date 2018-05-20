using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodsScript : MonoBehaviour {

	bool showMenu = false;
	bool decision = false;
	int pushed = 0;
	int pulled = 0;

	void Start() {
		
	}

	void OnCollisionEnter (Collision c) {
		if (c.gameObject.tag == "Rod") {
			showMenu = true;
			Debug.Log (showMenu);
		}
	}

	void OnCollisionExit (Collision c) {
		if (c.gameObject.tag == "Rod") {
			showMenu = false;
			if (decision) {
				decision = false;
				Destroy (c.gameObject);
			}
		}

		if (pushed + pulled == 3) {
			if (pushed > pulled) {
				// game manager good cube + 1
			} else {
				// game manager bad cube + 1
			}

			GameManager.instance_.fLevel ("Rods");
		}
	}

	void OnGui () {
		Debug.Log ("Here");
		if (showMenu) {
			if (GUI.Button (new Rect (10,10,150,100), "Push")) {
				pushed++;
			}
			else if (GUI.Button (new Rect (10,10,150,100), "Pull")) {
				pulled++;
			}
			decision = true;
		}
	}
}
