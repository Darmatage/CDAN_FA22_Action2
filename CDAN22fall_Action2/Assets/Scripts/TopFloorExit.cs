using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopFloorExit : MonoBehaviour{

	public GameObject stairsClosedArt;
	public GameObject stairsOpenArt;
	public GameObject stairsClosedText;
  
	public bool finishedAllTopPuzzles = false;

	void Start(){
		stairsClosedArt.SetActive(true);
		stairsOpenArt.SetActive(false);
		stairsClosedText.SetActive(true);
 
	}

	void Update(){

		//if ((GameTracking.escapedRoom1)&&(GameTracking.escapedRoom2)&&(GameTracking.escapedRoom3)){
		if ((GameTracking.escapedRoom1)&&(GameTracking.escapedRoom3)){
			finishedAllTopPuzzles = true;
		}
		
		if (finishedAllTopPuzzles == true){
			stairsClosedArt.SetActive(false);
			stairsOpenArt.SetActive(true);
			stairsClosedText.SetActive(false);
		}
	}
	
	
}
