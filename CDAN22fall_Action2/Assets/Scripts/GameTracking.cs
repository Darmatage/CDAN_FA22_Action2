using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTracking : MonoBehaviour{

	//the current room
	public static bool isHallway=false;
	public static bool isRoom1=false;
	public static bool isRoom2=false;
	public static bool isRoom3=false;
	public static bool isRoom4=false;
	public static bool isRoom5=false;
	public static bool isShop=false;
	public static bool finishedAllPuzzles=false;
	//public static bool isRoom6=false;
	//public static bool isRoom7=false;

	public bool isThisHallway=false;
	public bool isThisRoom1=false;
	public bool isThisRoom2=false;
	public bool isThisRoom3=false;
	public bool isThisRoom4=false;
	public bool isThisRoom5=false;
	public bool isThisShop=false;
	//public bool isThisRoom6=false;
	//public bool isThisRoom7=false;

	// puzzle 1 variables:
    public static bool escapedRoom1 = false;
	public static bool hasFoundKey1 = false;
    public static bool hasFoundLadder1 = false;

	//room 1 temp test variables
	public bool escapedRoom1_test = false;
    public bool hasFoundKey1_test = false;
    public bool hasFoundLadder1_test = false;


	// puzzle 2 variables:
      public static bool escapedRoom2 = false;
			public static bool hasFoundKey2 = false;

	 //room 2 temp test variables
		public bool escapedRoom2_test = false;
    public bool hasFoundKey2_test = false;


	  // puzzle 3 variables:
     public static bool escapedRoom3 = false;
		public static bool hasFoundCandle = false;
		public static bool hasFoundChalk = false;
		public static bool hasFoundSpell = false;

	//room 1 temp test variables
		public bool escapedRoom3_test = false;
    public bool hasFoundCandle_test = false;
    public bool hasFoundChalk_test = false;
	 public bool hasFoundSpell_test = false;




		// puzzle 4 variables:
      public static bool escapedRoom4 = false;



	  // puzzle 5 variables:
      public static bool escapedRoom5 = false;



// top floor hallway

public void AccessingDownstairs(){

				if ((escapedRoom1)&&(escapedRoom2)&&(escapedRoom3)){
					finishedAllPuzzles=true;
				}
			}

	// puzzle 6 variables:
      //public static bool escapedRoom6 = false;



	  // puzzle 7 variables:
      //public static bool escapedRoom7 = false;


	void Update(){
		//switch current room
		if (isThisRoom1){isRoom1=true;} else {isRoom1=false;}
		if (isThisRoom2){isRoom2=true;} else {isRoom2=false;}
		if (isThisRoom3){isRoom3=true;} else {isRoom3=false;}
		if (isThisRoom4){isRoom4=true;} else {isRoom4=false;}
		if (isThisRoom5){isRoom5=true;} else {isRoom5=false;}
		//if (isThisRoom6){isRoom6=true;} else {isRoom6=false;}
		//if (isThisRoom7){isRoom7=true;} else {isRoom7=false;}


		//room 1 testing
		if (escapedRoom1_test){escapedRoom1=true;} else {escapedRoom1=false;}
		if (hasFoundKey1_test){hasFoundKey1=true;} else {hasFoundKey1=false;}
		if (hasFoundLadder1_test){hasFoundLadder1=true;} else {hasFoundLadder1=false;}

		//room 2 testing
		if (escapedRoom2_test){escapedRoom2=true;} else {escapedRoom2=false;}
		if (hasFoundKey2_test){hasFoundKey2=true;} else {hasFoundKey2=false;}

	}

}
