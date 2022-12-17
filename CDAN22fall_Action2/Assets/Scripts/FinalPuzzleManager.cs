using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPuzzleManager : MonoBehaviour{
	public string theCode = ""; // the code. Use "h" for c2
	public int thePlace = 0; //current number of notes played
	public string playerCode = ""; //what player has played this round
	public int codeLength; //length of the code

	public GameObject theCodeBox;
	public GameObject theFail;
	public GameObject theCorrect;
	public AudioSource theClick;

	void Start(){
		theCodeBox.SetActive(false);
		theFail.SetActive(false);
		theCorrect.SetActive(false);
		
		if (theCode == ""){theCode = "cdef";}
		codeLength = theCode.Length;

		//Version
		//keyC1.pitch = 0.2f;
		//keyD.pitch = 0.3f;
		//keyE.pitch = 0.4f;
		//keyF.pitch = 0.5f;
		//keyG.pitch = 0.65f;
		//keyA.pitch = 0.8f;
		//keyB.pitch = 0.9f;
		//keyC2.pitch = keyC2.pitch;

	}

	void Update(){
		if (Input.GetKeyDown("c")){
				OpenCodebox();
		}
	}

	public void OpenCodebox(){

		theCodeBox.SetActive(true);
		theFail.SetActive(false);
		theCorrect.SetActive(false);
		thePlace = 0;
		playerCode ="";
	}

	public void CloseCodebox(){
		theCodeBox.SetActive(false);
		theFail.SetActive(false);
		theCorrect.SetActive(false);
		thePlace = 0;
		playerCode ="";
	}

	public void TryAgain(){
		theFail.SetActive(false);
		theCorrect.SetActive(false);
		thePlace = 0;
		playerCode ="";
	}

	void CheckCode(){
		if (playerCode == theCode){
			theCorrect.SetActive(true);
			Debug.Log("You solved the Final Code!");
			GameTracking.finalCodeSolved=true;
			
		} else {
			theFail.SetActive(true);
		}
	}

	//these functions get added to each button / piano key
	public void key1(){
		theClick.Play();
		playerCode = playerCode + "1";
		thePlace += 1;
		if (thePlace >= codeLength){ CheckCode(); }
	}

	public void key2(){
		theClick.Play();
		playerCode = playerCode + "2";
		thePlace += 1;
		if (thePlace >= codeLength){ CheckCode(); }
	}

	public void key3(){
		theClick.Play();
		playerCode = playerCode + "3";
		thePlace += 1;
		if (thePlace >= codeLength){ CheckCode(); }
	}

	public void key4(){
		theClick.Play();
		playerCode = playerCode + "4";
		thePlace += 1;
		if (thePlace >= codeLength){ CheckCode(); }
	}

	public void key5(){
		theClick.Play();
		playerCode = playerCode + "5";
		thePlace += 1;
		if (thePlace >= codeLength){ CheckCode(); }
	}

	public void key6(){
		theClick.Play();;
		playerCode = playerCode + "6";
		thePlace += 1;
		if (thePlace >= codeLength){ CheckCode(); }
	}

	public void key7(){
		theClick.Play();
		playerCode = playerCode + "7";
		thePlace += 1;
		if (thePlace >= codeLength){ CheckCode(); }
	}

	public void key8(){
		theClick.Play();
		playerCode = playerCode + "8";
		thePlace += 1;
		if (thePlace >= codeLength){ CheckCode(); }
	}
	
	public void key9(){
		theClick.Play();
		playerCode = playerCode + "9";
		thePlace += 1;
		if (thePlace >= codeLength){ CheckCode(); }
	}
	
	public void key0(){
		theClick.Play();
		playerCode = playerCode + "0";
		thePlace += 1;
		if (thePlace >= codeLength){ CheckCode(); }
	}

}

//Apply this script to the GameHandler or canvas
//Populate all gameObject slots

