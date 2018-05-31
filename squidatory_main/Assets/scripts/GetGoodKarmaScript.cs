using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetGoodKarmaScript : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision){

            //Play sound
            //FindObjectOfType<SoundManager>().Play("nameOfSound");

            //Add to good karma variable
            //GameManager.instance_.goodKarma_++;

            //Remove good karma box
            Destroy(gameObject);

            //Stop current music
            try
            {
                 FindObjectOfType<SoundManager>().Stop("cube_ambient");
            }
            catch
            {
                Debug.Log("Cube Amient sound not playing");
            }
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
