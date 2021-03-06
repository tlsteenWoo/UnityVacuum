﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(LevelChanger))]
public class ResetScript : MonoBehaviour {
	LevelChanger levelChanger;

	// Use this for initialization
	void Start () {
		levelChanger = GetComponent<LevelChanger> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Reset") > 0) {
			Reset();
		}
	}

	public void Reset()
	{
		levelChanger.GotoLevel(Application.loadedLevel);
	}
}
