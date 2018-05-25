using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodsScript : MonoBehaviour {

	bool showMenu = false;
	bool decision = false;
	int pushed = 0;
	int pulled = 0;

	Collision current_c;

	void OnCollisionEnter (Collision c) {
		if (c.gameObject.tag == "Rod") {
			current_c = c;
			showMenu = true;
		}
	}

	void OnCollisionExit (Collision c) {
		if (c.gameObject.tag == "Rod") {
			current_c = c;
			showMenu = false;
			if (decision) {
				decision = false;
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

	void OnGUI () {
		Debug.Log ("Here");
		if (showMenu) {
			if (GUI.Button (new Rect (10,10,75,50), "Push")) {
				pushed++;
				decision = true;
				showMenu = false;
				Destroy (current_c.gameObject);
			}
			else if (GUI.Button (new Rect (90,10,75,50), "Pull")) {
				pulled++;
				decision = true;
				showMenu = false;
				Destroy (current_c.gameObject);
			}
		}
	}
}
