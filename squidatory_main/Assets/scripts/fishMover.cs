using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMover : MonoBehaviour {
    private bool dirRight = true;
    public float speed = 4.0f;
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 4.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -4)
        {
            dirRight = true;
        }
        //transform.Translate(0, 0, Time.deltaTime);
        //transform.Translate(Time.deltaTime * 10, 0, 0, Space.World);
    }
}
