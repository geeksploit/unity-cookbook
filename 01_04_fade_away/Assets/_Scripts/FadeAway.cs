using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof (CountdownTimer))]
public class FadeAway : MonoBehaviour {
	private CountdownTimer countdownTimer;
	private Text textUi;

	void Awake () {
		textUi = GetComponent<Text>();
		countdownTimer = GetComponent<CountdownTimer>();
	}

	// Use this for initialization
	void Start () {
		countdownTimer.ResetTimer(5);
	}
	
	// Update is called once per frame
	void Update () {
		float alphaRemaining = countdownTimer.GetProportionTimeRemaining();
		print(alphaRemaining);
		Color newColor = textUi.color;
		newColor.a = alphaRemaining;
		textUi.color = newColor;
	}
}
