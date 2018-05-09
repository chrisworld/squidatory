using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController3D : MonoBehaviour {

	// source: https://stackoverflow.com/a/47904587

	public GameObject player_;
	public float cameraDist_ = 7.0f;

	void Start () {
		
	}
		
	void LateUpdate () {
		transform.position = player_.transform.position - player_.transform.forward * cameraDist_;
		transform.LookAt (player_.transform.position);
		transform.position = new Vector3 (transform.position.x, transform.position.y + 2, transform.position.z);
	}
}
