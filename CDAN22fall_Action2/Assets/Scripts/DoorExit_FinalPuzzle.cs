using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorExit_FinalPuzzle : MonoBehaviour{

	public GameObject doorOpenArt;
	public GameObject doorClosedArt;
	public GameObject doorClosedText;


	void Start(){
		doorOpenArt.SetActive(false);
		doorClosedArt.SetActive(true);
		doorClosedText.SetActive(true);
	}

	void Update(){
		if ((GameTracking.finalCodeSolved == true)){
			doorOpenArt.SetActive(true);
			doorClosedArt.SetActive(false);
			doorClosedText.SetActive(false);
		 }
	}


}
