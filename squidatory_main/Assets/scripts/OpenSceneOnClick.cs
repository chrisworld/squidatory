using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenSceneOnClick : MonoBehaviour {

    public void LoadByScene(int sIndex)
    {
        SceneManager.LoadScene(sIndex);
    }
}
