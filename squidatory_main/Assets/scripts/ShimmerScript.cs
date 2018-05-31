using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShimmerScript : MonoBehaviour {

	bool showText = false;

	void OnCollisionEnter (Collision c) {
		if (c.collider.name == "Character") {
			showText = true;
		}
	}

	void OnCollisionExit (Collision c) {
		if (c.collider.name == "Character") {
			showText = false;
		}
	}

	void OnGUI () {
		if (showText) {
			GUI.Box (new Rect (30, 60, 295, 140), "It's so dark, I can't see. Please help me!");
			if (GUI.Button (new Rect (40, 90, 270, 40), "Give away shimmer")) {
				showText = false;
			}
			else if (GUI.Button (new Rect (40, 140, 270, 40), "Keep shimmer")) {
				showText = false;
			}

		}
	}
}
