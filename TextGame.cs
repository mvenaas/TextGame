﻿using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame () {

		max = 1000;
		min = 1;
		guess = 500;

		print ("===================================");
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up for higher, down for lower, return for equal");

		// To make 1000 possible. Algorithm hits 999, doubles it and divides by 2. 
		max = max + 1; 
	} 

	void NextGuess() {
		guess = (max + min) / 2; 
		print ("Higher or lower than" + guess +"?");
		print ("Up for higher, down for lower, return for equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess; 
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess; 
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame();
		}
	}
}
