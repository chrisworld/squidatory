using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlatformScript : MonoBehaviour {

	void OnCollisionEnter(Collision c) {
		if (c.collider.tag == "MovingPlatform") {
			transform.parent = c.transform;
		}
	}

	void OnCollisionExit(Collision c) {
		if (c.collider.tag == "MovingPlatform") {
			transform.parent = null;
		}
	}
}
