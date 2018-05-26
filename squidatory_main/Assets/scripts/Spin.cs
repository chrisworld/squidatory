using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

	//Speed of rotation
	public float speed = 60f;
	
	// Update is called once per frame
	void Update () {
		//Rotates object anti-clockwise on Y-axis on each update
		transform.Rotate(Vector3.left, speed * Time.deltaTime);
	}
}