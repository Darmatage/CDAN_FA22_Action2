using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTracking : MonoBehaviour{

	public GameObject finalCode1;
	public GameObject finalCode2;
	public GameObject finalCode3;
	public GameObject finalCode4;

	public static bool finalCodeSolved = false;

	public static string recentRoom = "room1";

	//the current room
	public static bool isHallway = false;
	public static bool isRoom1 = false;
	public static bool isRoom2 = false;
	public static bool isRoom3 = false;
	public static bool isRoom4 = false;
	public static bool isRoom5 = false;
	public static bool isShop = false;
	public static bool finishedAllPuzzles = false;
	//public static bool isRoom6=false;
	//public static bool isRoom7=false;

	public bool isThisHallway = false;
	public bool isThisRoom1 = false;
	public bool isThisRoom2 = false;
	public bool isThisRoom3 = false;
	public bool isThisRoom4 = false;
	public bool isThisRoom5 = false;
	public bool isThisShop = false;
	//public bool isThisRoom6=false;
	//public bool isThisRoom7=false;

	// puzzle 1 variables (first bedroom):
    public static bool escapedRoom1 = false;
	public static bool hasFoundKey1 = false;
    public static bool hasFoundLadder1 = false;

	//room 1 temp test variables
		//public bool escapedRoom1_test = false;
		//public bool hasFoundKey1_test = false;
		//public bool hasFoundLadder1_test = false;


	// puzzle 2 variables (bathroom):
	public static bool escapedRoom2 = false;
	public static bool hasFoundKey2 = false;

	 //room 2 temp test variables
		//public bool escapedRoom2_test = false;
		//public bool hasFoundKey2_test = false;


	// puzzle 3 variables (goth sibling room):
	public static bool escapedRoom3 = false;
	public static bool hasFoundCandle = false;
	public static bool hasFoundChalk = false;
	public static bool hasFoundSpell = false;

	//room 1 temp test variables
		//public bool escapedRoom3_test = false;
		//public bool hasFoundCandle_test = false;
		//public bool hasFoundChalk_test = false;
		//public bool hasFoundSpell_test = false;


	// puzzle 4 variables (kitchen):
	public static bool escapedRoom4 = false;

	// puzzle 5 variables (living room):
	public static bool escapedRoom5 = false;

	// puzzle 6 variables:
	//public static bool escapedRoom6 = false;

	// puzzle 7 variables:
	//public static bool escapedRoom7 = false;

	//Shop Clue bools
	public static bool gotClue1 = false;
	public static bool gotClue2 = false;
	public static bool gotClue3 = false;
	public static bool gotClue4 = false;


	//BIG TESTING VARIABLES
	[Header("TESTING BOOLS: DO NOT CLICK")]
	public bool haveIBeenInRm1 = false;
	public bool haveIBeenInRm2 = false;
	public bool haveIBeenInRm3 = false;
	public bool haveIBeenInRm4 = false;
	public bool haveIBeenInRm5 = false;

	void Start(){
		finalCode1.SetActive(false);
		finalCode2.SetActive(false);
		finalCode3.SetActive(false);
		finalCode4.SetActive(false);
	}


	void Update(){
		//switch current room
		if (isThisRoom1){
			isRoom1 = true; 
			recentRoom = "room1"; 
			escapedRoom1 = true;
			Debug.Log("I was in room 1: " + recentRoom);
		} else {isRoom1 = false;}
			
		if (isThisRoom2){
			isRoom2 = true; 
			recentRoom = "room2"; 
			escapedRoom2 = true;
			Debug.Log("I was in room 2: " + recentRoom);
		} else {isRoom2 = false;}
		
		if (isThisShop){
			isShop = true; 
			recentRoom = "shop";
			Debug.Log("I was in the shop: " + recentRoom);
		} else {isRoom2 = false;}
			
		if (isThisRoom3){
			isRoom3=true; 
			recentRoom = "room3"; 
			escapedRoom3 = true;
			Debug.Log("I was in room 3: " + recentRoom);
		} else {isRoom3 = false;}
			
		if (isThisRoom4){
			isRoom4 = true; 
			recentRoom = "room4"; 
			escapedRoom4 = true;
			Debug.Log("I was in room 4: " + recentRoom);
		} else {isRoom4 = false;}
			
		if (isThisRoom5){
			isRoom5 = true;
			recentRoom = "room5";
			escapedRoom5 = true;
			Debug.Log("I was in room 5: " + recentRoom);
		} else {isRoom5 = false;}
			
			
		if ((escapedRoom1)&&(escapedRoom3)&&(escapedRoom5)){
			finishedAllPuzzles = true;
		}

		//if (isThisRoom6){isRoom6=true;} else {isRoom6=false;}
		//if (isThisRoom7){isRoom7=true;} else {isRoom7=false;}

		//room 1 testing
		//if (escapedRoom1_test){escapedRoom1=true;} else {escapedRoom1=false;}
		//if (hasFoundKey1_test){hasFoundKey1=true;} else {hasFoundKey1=false;}
		//if (hasFoundLadder1_test){hasFoundLadder1=true;} else {hasFoundLadder1=false;}

		//room 2 testing
		//if (escapedRoom2_test){escapedRoom2=true;} else {escapedRoom2=false;}
		//if (hasFoundKey2_test){hasFoundKey2=true;} else {hasFoundKey2=false;}
		
		//BIG TEST:
		if (escapedRoom1){
			haveIBeenInRm1 = true;
			finalCode1.SetActive(true); //final code 1
		}else { 
			haveIBeenInRm1 = false;
			}
		if (escapedRoom2){
			haveIBeenInRm2 = true;
			finalCode3.SetActive(true);  //final code 3
		}else { 
			haveIBeenInRm2 = false;
		}
		if (escapedRoom3){
			haveIBeenInRm3 = true;
			finalCode2.SetActive(true);  //final code 2
		}else { 
			haveIBeenInRm3 = false;
		}
		if (escapedRoom4){
			haveIBeenInRm4 = true;
		}else { 
			haveIBeenInRm4 = false;
		}
		if (escapedRoom5){
			haveIBeenInRm5 = true;
			finalCode4.SetActive(true);  //final code 4
		}else { 
			haveIBeenInRm5=false;
		}
	}

}
