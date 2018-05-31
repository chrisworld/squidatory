using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour {

	private Transform playerTransform;
	public Planet attractorPlanet;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().useGravity = false;
		GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotation;

		playerTransform = transform;
	}
	
	void FixedUpdate()
	{
		if (attractorPlanet) {
			attractorPlanet.Attract(playerTransform);
		}
	}
}
