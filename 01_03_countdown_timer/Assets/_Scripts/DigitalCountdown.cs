using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitalCountdown : MonoBehaviour {
	private Text textClock;
	private CountdownTimer countdownTimer;

	void Awake () {
		textClock = GetComponent<Text>();
		countdownTimer = GetComponent<CountdownTimer>();
	}

	// Use this for initialization
	void Start () {
		countdownTimer.ResetTimer(30);
	}
	
	// Update is called once per frame
	void Update () {
		int timeRemaining = countdownTimer.GetSecondsRemaining();
		string message = TimerMessage(timeRemaining);
		textClock.text = message;
	}

	private string TimerMessage(int secondsLeft) {
		if (secondsLeft <= 0)
			return "Countdown timer\nhas finished";
		else
			return "Countdown timer\n" + secondsLeft;
	}
}
