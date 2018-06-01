using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
				GameManager.instance_.badKarma_++;
			} else {
				GameManager.instance_.goodKarma_++;
			}

			GameManager.instance_.fLevel ("Rods");
						FindObjectOfType<SoundManager>().Stop("cube_theme");
						FindObjectOfType<SoundManager>().Stop("cube_ambient");
            FindObjectOfType<SoundManager>().Play("squid_theme");
            if (GameManager.instance_.goodKarma_ > GameManager.instance_.badKarma_)
            {
                SceneManager.LoadScene("GoodEnding");
            } else
            {
                SceneManager.LoadScene("BadEnding");
            }
		}
	}

	void OnGUI () {
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
