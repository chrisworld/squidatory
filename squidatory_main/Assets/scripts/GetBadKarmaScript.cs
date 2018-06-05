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
            FindObjectOfType<SoundManager>().Stop("squid_theme");
        }
        catch
        {
            Debug.Log("Cube Amient sound not playing");
        }

        //Play sound
        FindObjectOfType<SoundManager>().Play("black_cube");

        //Add to bad karma variable
        GameManager.instance_.badKarma_++;

        //Increase level completed variable
        GameManager.instance_.fLevel(SceneManager.GetActiveScene().name);

        //Remove bad karma box
        Destroy(gameObject);

        //Start Cube theme music
        FindObjectOfType<SoundManager>().Play("cube_theme");

        //Return back to 3D world
        if (GameManager.instance_.goodKarma_ + GameManager.instance_.badKarma_ >= 6){
            SceneManager.LoadScene("OuterWorldRods");
        }
        else{
            SceneManager.LoadScene("OuterWorld");
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
