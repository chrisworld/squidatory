using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrav2 : MonoBehaviour {

	public Transform centreOfGravity;    //The object to gravitate towards, in this case the cube
	public float gravity = 1f;    //The force of the gravity to be applied
	public float maxDistance;    //The maximum distance from the centreOfGravity this object can be whilst still being affected by gravity

	private Rigidbody rb;

	void FixedUpdate () 
	{
		if (!GetComponent<Rigidbody>())
			return;    //If no rigidbody attached, return
		if (Vector3.Distance (transform.position, centreOfGravity.position) > maxDistance)
			return;    //If we are further than the max distance, return

		if (!rb)
			rb = GetComponent<Rigidbody>();    //If the rb variable is null, get the rigidbody attached to this object
		if (rb.useGravity)
			rb.useGravity = false;    //Make sure the rigidbody isn't using the global gravity variable

		Vector3 direction = (centreOfGravity.position - transform.position).normalized;    //Get the direction of the cube and normalize so it doesn't have distance
		RaycastHit hit; 
		Ray Directionray = new Ray(transform.position, direction);
		//Will contain information about the raycast we are about to perform
		if(centreOfGravity.GetComponent<Collider>().Raycast (Directionray, out hit,maxDistance))
			rb.AddForce (-hit.normal * gravity * rb.mass);  
		
		//if(centreOfGravity.GetComponent<Collider>().Raycast (direction,hit,maxDistance))
		//Apply the force to the rigidbody towards the relative surface of the cube.
		//*note* that this will multiply the force by the rigidbody's mass so that all objects
		//will fall at the same rate. If you don't want this, remove that section
		//Physics.Raycast(transform.position,direction, out hit,maxDistance);
	}
	}