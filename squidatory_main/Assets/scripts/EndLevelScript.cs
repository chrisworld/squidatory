using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelScript : MonoBehaviour {

	void OnCollisionEnter (Collision c) {
		if (c.collider.tag == "Player") {
			GameManager.instance_.fLevel (SceneManager.GetActiveScene ().name);

			if (c.gameObject.tag == "WhiteCube") {
				GameManager.instance_.goodKarma_++;
			} else if (c.gameObject.tag == "BlackCube") {
				GameManager.instance_.badKarma_++;
			}
		}
	} 
}
