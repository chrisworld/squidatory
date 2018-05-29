﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance_ = null;

	// list of finished levels
	public ArrayList fLvls_;
	public int goodKarma_ = 0;
	public int badKarma_ = 0;

	// Use this for initialization
	void Start () {
		
	}

	void Awake () {
		fLvls_ = new ArrayList ();

		if (instance_ == null) {
			instance_ = this;
		} else if (instance_ != this) {
			DestroyObject (gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

	// add level to finished level list
	public void fLevel(string lvl) {
		if (!isFinished(lvl)) {
			fLvls_.Add (lvl);
		}
	}

	// check if level already in finished list
	public bool isFinished(string lvl) {
		foreach (string value in fLvls_) {
			if (value.ToLower().Equals(lvl.ToLower())) {
				return true;
			}
		}
		return false;
	}

	// get finished level count
	public int getFLvlCount() {
		return fLvls_.Count;
	}
}
