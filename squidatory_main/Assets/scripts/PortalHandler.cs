using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalHandler : MonoBehaviour {

  // Use this for initialization
  void Start () {
    // check if portals done and destroy them 
    // name of scene of finish check
    if (GameManager.instance_.isFinished("Balance")){
      GameObject level = GameObject.Find("Level1Plane");
      Destroy(level);
    }
    if (GameManager.instance_.isFinished("Coin Collection")){
      GameObject level = GameObject.Find("Level2Plane");
      Destroy(level);
    }
    if (GameManager.instance_.isFinished("Code")){
      GameObject level = GameObject.Find("Level3Plane");
      Destroy(level);
    }
    if (GameManager.instance_.isFinished("Shimmer")){
      GameObject level = GameObject.Find("Level4Plane");
      Destroy(level);
    }
    if (GameManager.instance_.isFinished("Moving Platforms")){
      GameObject level = GameObject.Find("Level5Plane");
      Destroy(level);
    }
    if (GameManager.instance_.isFinished("Maze")){
      GameObject level = GameObject.Find("Level6Plane");
      Destroy(level);
    }
  }
  
  // Update is called once per frame
  void Update () {
    
  }
}
