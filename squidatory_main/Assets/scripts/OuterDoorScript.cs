using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OuterDoorScript : MonoBehaviour {

    private void OnTriggerEnter(Collider collider)
    {
        string door = collider.gameObject.name;

        if (door == "Level1Plane")
        {
            SceneManager.LoadScene("Balance");
        }
        if (door == "Level2Plane")
        {
            SceneManager.LoadScene("Coin Collection");
        }
        if (door == "Level3Plane")
        {
            SceneManager.LoadScene("Moving Platforms");
        }
        if (door == "Level4Plane")
        {
            SceneManager.LoadScene("Shimmer");
        }
        if (door == "Level5Plane")
        {
            SceneManager.LoadScene("Code");
        }
        if (door == "Level6Plane")
        {
            SceneManager.LoadScene("Maze");
        }
    }
}
