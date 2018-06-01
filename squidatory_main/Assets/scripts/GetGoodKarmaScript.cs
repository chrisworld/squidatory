using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetGoodKarmaScript : MonoBehaviour {
    
    private void OnCollisionEnter2D(Collision2D collision){

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
             FindObjectOfType<SoundManager>().Play("white_cube");

            //Add to good karma variable
            //GameManager.instance_.goodKarma_++;

            //Remove good karma box
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
