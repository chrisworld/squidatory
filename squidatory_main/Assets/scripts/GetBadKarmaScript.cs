using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetBadKarmaScript : MonoBehaviour {


    private void OnCollisionEnter2D(Collision2D collision)
    {

        //Stop current music
        try
        {
            FindObjectOfType<SoundManager>().Stop("cube_ambient");
        }
        catch
        {
            Debug.Log("Cube Amient sound not playing");
        }

        //Play sound
        FindObjectOfType<SoundManager>().Play("black_cube");

        //Add to bad karma variable
        GameManager.instance_.badKarma_++;

        //Remove bad karma box
        Destroy(gameObject);

        //Start Cube theme music
        FindObjectOfType<SoundManager>().Play("cube_theme");

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
