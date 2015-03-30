using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		max = max + 1;

		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a Number in Your Head, but Don't Tell Me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return(enter) = equal");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//print ("Up arrow pressed");
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess ();
			//print ("Down arrow pressed");
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I Won");
			StartGame ();
		}
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return(enter) = equal");
	}
}
