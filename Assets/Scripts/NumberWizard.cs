using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	int max;
	int min;
	int guess;
	string inputHolder = "";
	bool maxSet = false;
	bool minSet = false;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame () {
		print ("========================");
		print ("Welcome to Number Wizard");

		print ("Select range for this game!");
		print ("Type the minimum value of the number and press enter");
	}

	// Update is called once per frame
	void Update () {

		if (maxSet && minSet){
			if (Input.GetKeyDown(KeyCode.UpArrow)) {
				min = guess;
				NextGuess ();
			} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
				max = guess;
				NextGuess ();
			} else if (Input.GetKeyDown(KeyCode.Return)) {
				print ("I Won");
				StartGame ();
			}
		} else if (minSet && !maxSet) {
			if (Input.GetKeyDown (KeyCode.Return)) {
				max = int.Parse(inputHolder);
				maxSet = true;
				guess = (max + min) / 2;
				print ("MAX VALUE: " + max);
				print ("You selected the range to be between " + min + " and " + max);
				print ("Now Pick a Number in Your Head, but Don't Tell Me!");
				print ("Is the number higher or lower than " + guess + "?");
				print ("Up = higher, down = lower, return(enter) = equal");
			} else {
				NumericInput();
			}
			
		} else {
			if (Input.GetKeyDown (KeyCode.Return)) {
				min = int.Parse(inputHolder);
				minSet = true;
				inputHolder = "";
				print ("MIN VALUE: " + min);
				print ("Type the maximum value of the number and press enter");
			} else {
				NumericInput();
			}

		}

	}

	void NumericInput(){
		if (Input.GetKeyDown(KeyCode.Alpha0)){
			inputHolder = inputHolder + "0";
		} else if (Input.GetKeyDown(KeyCode.Alpha1)) {
			inputHolder = inputHolder + "1";
		} else if (Input.GetKeyDown(KeyCode.Alpha2)) {
			inputHolder = inputHolder + "2";
		} else if (Input.GetKeyDown(KeyCode.Alpha3)) {
			inputHolder = inputHolder + "3";
		} else if (Input.GetKeyDown(KeyCode.Alpha4)) {
			inputHolder = inputHolder + "4";
		} else if (Input.GetKeyDown(KeyCode.Alpha5)) {
			inputHolder = inputHolder + "5";
		} else if (Input.GetKeyDown(KeyCode.Alpha6)) {
			inputHolder = inputHolder + "6";
		} else if (Input.GetKeyDown(KeyCode.Alpha7)) {
			inputHolder = inputHolder + "7";
		} else if (Input.GetKeyDown(KeyCode.Alpha8)) {
			inputHolder = inputHolder + "8";
		} else if (Input.GetKeyDown(KeyCode.Alpha9)) {
			inputHolder = inputHolder + "9";
		}	
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return(enter) = equal");
	}

	/*
	string GetNumberInput(){
		string input = "";
		var enterPressed = false;
		//Event e = Event.current;

		while (!enterPressed){

			if(Input.anyKeyDown){
				if (Input.GetKeyDown (KeyCode.Return)) {
					enterPressed = true;
				} else if (Input.GetKeyDown(KeyCode.Alpha0)){
					input.Insert(input.Length, "0");
				} else if (Input.GetKeyDown(KeyCode.Alpha1)) {
					input.Insert(input.Length, "1");
				} else if (Input.GetKeyDown(KeyCode.Alpha2)) {
					input.Insert(input.Length, "2");
				} else if (Input.GetKeyDown(KeyCode.Alpha3)) {
					input.Insert(input.Length, "3");
				} else if (Input.GetKeyDown(KeyCode.Alpha4)) {
					input.Insert(input.Length, "4");
				} else if (Input.GetKeyDown(KeyCode.Alpha5)) {
					input.Insert(input.Length, "5");
				} else if (Input.GetKeyDown(KeyCode.Alpha6)) {
					input.Insert(input.Length, "6");
				} else if (Input.GetKeyDown(KeyCode.Alpha7)) {
					input.Insert(input.Length, "7");
				} else if (Input.GetKeyDown(KeyCode.Alpha8)) {
					input.Insert(input.Length, "8");
				} else if (Input.GetKeyDown(KeyCode.Alpha9)) {
					input.Insert(input.Length, "9");
				}
			}


			if(e.type == EventType.KeyDown) {
				int key = (int)e.keyCode - (int)KeyCode.Alpha1;
				if (key >= 0 && key < 9)
				{
					var index = input.Length;
					input.Insert(index, key.ToString());
					Event.current.Use();
				}
			}

		}
		
		return input;
		
	}
	*/
}
