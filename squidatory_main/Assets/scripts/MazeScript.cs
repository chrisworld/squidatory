using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//int completedLvls = GameManager.instance_.getFLvlCount ();

		// For testing purposes:
		 int completedLvls = 5;

		for (int i = 1; i <= completedLvls; i++) {
			string door = "MazeDoor" + i.ToString ();
			GameObject obj = GameObject.Find (door);
			DestroyObject (obj);
		}
	}
}
