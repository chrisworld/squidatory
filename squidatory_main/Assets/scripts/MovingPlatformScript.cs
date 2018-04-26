using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformScript : MonoBehaviour {

	/* Platfrom positioning variables */
	public Transform movingPlatform; // Platform current position
	public Transform position1; // Start positon of platform
	public Transform position2; // End positon of platform

	/* Platform movement variables */
	public Vector3 newPosition; // Moves platform
	public string currentDirection; // Holds current direction of platform
	public float smooth; // Controls smooth movement
	public float resetTime; // Controls speed


	// Use this for initialization
	void Start () {
		/* Set inital target for platform to move towards */
		ChangeTarget ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		/* Moves platform from current position to new position over set time */
		movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPosition, smooth * Time.deltaTime);
	}

	/* Change direction of platform when reched end positions */
	void ChangeTarget (){
		/* Check for current direction and revert */
		if (currentDirection == "Towards Position 1"){
			currentDirection = "Towards Position 2";
			newPosition = position2.position;
		} else if (currentDirection == "Towards Position 2"){
			currentDirection = "Towards Position 1";
			newPosition = position1.position;
		} else if (currentDirection == ""){ //Sets a direction if not initalised
			currentDirection = "Towards Position 2";
			newPosition = position2.position;
		} 
		Invoke ("ChangeTarget", resetTime);
	}
}