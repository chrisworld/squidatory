using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;

	private Vector3 moveDirection;

	void Update () {

		moveDirection = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")).normalized;
			//Input.GetAxisRaw ("Vertical")).normalized;
		//Input.GetAxisRaw ("Horizontal")
	}

	void FixedUpdate()
	{
		GetComponent<Rigidbody> ().MovePosition (GetComponent<Rigidbody> ().position + transform.TransformDirection (moveDirection));
	}
}
	
