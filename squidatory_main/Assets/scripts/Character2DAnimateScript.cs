using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DAnimateScript : MonoBehaviour {

    Animator m_Animator;

	// Use this for initialization
	void Start () {
        m_Animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        //Check if jumping
        bool isJumpingPressed = false;
        bool isWalkingPressed = false;
        if (Input.GetKey("space"))
        {
            isJumpingPressed = true;
        } else {
            //Check if walking
            if (Input.GetKey("a") || Input.GetKey("d"))
            {
                isWalkingPressed = true;
            }
        }
        m_Animator.SetBool("isJumping", isJumpingPressed);
        m_Animator.SetBool("isWalking", isWalkingPressed);

	}
}
