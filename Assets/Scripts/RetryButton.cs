﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryButton : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)) Application.LoadLevel("main");
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
    }

    public void onRetryClick() {
        Application.LoadLevel("main");
    }
}
