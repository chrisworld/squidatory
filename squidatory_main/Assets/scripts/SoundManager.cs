/*
Adapted from "Brackeys" @ https://youtu.be/6OT43pvUyfY
Usage of Sound Manager:
Add and set sounds in SoundManager
Play a Sound with:
FindObjectOfType<SoundManager>().Play("nameOfSound");
*/

using System;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour {

  // Array that holds all sounds in game
  public Sound[] sounds;
  [HideInInspector]
  public bool badass_activated;
  [HideInInspector]
  public bool badass_music_on;

  // Singelton instance
  public static SoundManager instance;

  // Init Sounds
  void Awake () {
    // keep the same SoundManager through Scenes
    if (instance == null){
      instance = this;
    }
    else{
      Destroy(gameObject);
      return;
    }
    DontDestroyOnLoad(gameObject);

    // Add an AudioSource for each sound and init
    foreach (Sound s in sounds){
      s.source = gameObject.AddComponent<AudioSource>();
      s.source.clip = s.clip;
      s.source.volume = s.volume;
      s.source.pitch = s.pitch;
      s.source.loop = s.loop;
    }
  }

  // play sounds at the start of the game
  void Start (){
    //Play("jump"); 
    //Play("walking"); 
    //Play("cube_theme"); 
    Play("squid_theme"); 
    //Play("button"); 
    badass_activated = false;
    badass_music_on = false;
  }

  // Update is called once per frame
  void Update () {
  	if (badass_activated){
      if (Input.GetKeyDown(KeyCode.M)){
        if (!badass_music_on){
          Stop("cube_theme");
          Play("badass");
          badass_music_on = true;
        }
        else {
          Play("cube_theme");
          Stop("badass");
          badass_music_on = false;
        }
      }
    }
  }

  // play specific Sound
  public void Play (string name){
    Sound s = Array.Find(sounds, sound => sound.name == name);
    if (s == null){
      Debug.LogWarning("Sound: " + name + " not found! -> check SoundManager");
      return;
    }
    s.source.Play();
  }

    // stop specific Sound
  public void Stop (string name){
    Sound s = Array.Find(sounds, sound => sound.name == name);
    if (s == null){
      Debug.LogWarning("Sound: " + name + " not found! -> check SoundManager");
      return;
    }
    s.source.Stop();
  }

  public void setBadass(){
    badass_activated = true;
  }
}
