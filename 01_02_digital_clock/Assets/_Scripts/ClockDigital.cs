using System;
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockDigital : MonoBehaviour {
	private Text textClock;


	void Awake() {
		textClock = GetComponent<Text>();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		DateTime time = DateTime.Now;
		textClock.text = time.ToString("hh:mm:ss");
	}
}
