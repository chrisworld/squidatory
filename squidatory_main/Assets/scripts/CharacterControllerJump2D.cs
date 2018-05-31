using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerJump2D : MonoBehaviour {

	public float speed = 0.1f;
	public float jumpHeight = 0.2f;

	private bool isGrounded = true;
	private Rigidbody player;

	void FixedUpdate () {
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate (Vector2.left * speed);
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate (Vector2.right * speed);
		}
		if (Input.GetKey(KeyCode.Space) && isGrounded) {
			isGrounded = false;
			transform.Translate (Vector2.up * jumpHeight);
		}
	}

	void OnCollisionEnter2D (Collision2D c) {
		if (c.collider.name == "Ground") {
			isGrounded = true;
		}
	}
}
