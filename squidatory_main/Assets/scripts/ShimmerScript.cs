using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShimmerScript : MonoBehaviour {

	bool showText = false;

	void OnCollisionEnter2D (Collision2D c) {
		if (c.collider.name == "BatMan") {
			showText = true;
		}
	}

	void OnCollisionExit2D (Collision2D c) {
		if (c.collider.name == "BatMan") {
			showText = false;
		}
	}

	void OnGUI () {
		if (showText) {
			GUI.Box (new Rect (30, 60, 295, 140), "It's so dark, I can't see. Please help me!");
            if (GUI.Button (new Rect (40, 90, 270, 40), "Give away shimmer")) {
				showText = false;
                good();
			}
			else if (GUI.Button (new Rect (40, 140, 270, 40), "Keep shimmer")) {
				showText = false;
                bad();
			}

		}
	}

    void good(){
        GameObject.Find("2D_Box_White2").transform.Translate(0, 10, 0);
    }

    void bad()
    {
        GameObject.Find("2D_Box_Black2").transform.Translate(0, 10, 0);
    }
}
