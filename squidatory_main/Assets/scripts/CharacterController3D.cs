using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController3D : MonoBehaviour {
	// source: https://www.youtube.com/watch?v=BBS2nIKzmbw

	public float inputDelay = 0.5f;
	public float forVel = 12;
	public float rotVel = 100;

	Quaternion targetRotation;
	Rigidbody rBody;
	float forwardInput, turnInput;

	public Quaternion TargetRotation {
		get { return targetRotation; }
	}

	void Start () {
		targetRotation = transform.rotation;
		if (GetComponent<Rigidbody> ()) {
			rBody = GetComponent<Rigidbody> ();	
		} else {
			Debug.LogError ("Character needs a rigidbody");
		}

		forwardInput = 0;
		turnInput = 0;
	}

	void GetInput() {
		forwardInput = Input.GetAxis ("Vertical");
		turnInput = Input.GetAxis ("Horizontal");
	}

	void Update () {
		GetInput ();
		Turn ();
	}

	void FixedUpdate () {
		Move ();
	}

	void Move () {
		if (Mathf.Abs(forwardInput) > inputDelay) {
			//move
			rBody.velocity = transform.forward * forwardInput * forVel;
		} else {
			//don'tmove
			rBody.velocity = Vector3.zero;
		}
	}

	void Turn () {
		if (Mathf.Abs (turnInput) > inputDelay) {
			targetRotation *= Quaternion.AngleAxis (rotVel * turnInput * Time.deltaTime, Vector3.up);
		}
		transform.rotation = targetRotation;
	}
}
