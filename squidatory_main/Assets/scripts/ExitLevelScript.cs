using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevelScript : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("COL");
        //Return back to 3D world
        SceneManager.LoadScene("OuterWorld");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
