using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoManager : MonoBehaviour{
	public string theNotes = ""; // the code. Use "h" for c2
	public int thePlace = 0; //current number of notes played
	public string playerNotes = ""; //what player has played this round
	public int notesLength; //length of the code

	public float pitchChange = 5.95f;

	public GameObject thePiano;
	public GameObject theFail;
	public GameObject theCorrect;
	public GameObject theLoot;
	public Transform drawerPos;
	public GameObject drawerLocked;
	public GameObject drawerOpened;

	public AudioSource keyC1;
	public AudioSource keyD;
	public AudioSource keyE;
	public AudioSource keyF;
	public AudioSource keyG;
	public AudioSource keyA;
	public AudioSource keyB;
	public AudioSource keyC2;


	void Start(){
		thePiano.SetActive(false);
		theFail.SetActive(false);
		drawerLocked.SetActive(true);
		drawerOpened.SetActive(false);
		
		if (theNotes == ""){theNotes = "cdef";}
		notesLength = theNotes.Length;

		//Version1
		// keyC1.pitch = keyC1.pitch;
		// keyD.pitch = keyD.pitch + (1/pitchChange) -0.1f;
		// keyE.pitch = keyE.pitch + ((1/pitchChange)*2) -0.1f;
		// keyF.pitch = keyF.pitch + ((1/pitchChange)*3) -0.1f;
		// keyG.pitch = keyG.pitch + ((1/pitchChange)*4) -0.1f;
		// keyA.pitch = keyA.pitch + ((1/pitchChange)*5) -0.1f;
		// keyB.pitch = keyB.pitch + ((1/pitchChange)*6) -0.1f;
		// keyC2.pitch = keyC2.pitch + ((1/pitchChange)*7) -0.1f;

		//Version1b
		//keyC1.pitch = 0.2f;
		//keyD.pitch = 0.3f;
		//keyE.pitch = 0.4f;
		//keyF.pitch = 0.5f;
		//keyG.pitch = 0.65f;
		//keyA.pitch = 0.8f;
		//keyB.pitch = 0.9f;
		//keyC2.pitch = keyC2.pitch;


		//Version2
		// keyC1.pitch = keyC1.pitch;
		// keyD.pitch = keyD.pitch * (9/8);
		// keyE.pitch = keyE.pitch * (5/4);
		// keyF.pitch = keyF.pitch * (4/3);
		// keyG.pitch = keyG.pitch * (3/2);
		// keyA.pitch = keyA.pitch * (5/3);
		// keyB.pitch = keyB.pitch * (15/8);
		// keyC2.pitch = keyC2.pitch * 2;

	}

	void Update(){
		if (Input.GetKeyDown("p")){
				OpenPiano();
		}
	}

	public void OpenPiano(){

		thePiano.SetActive(true);
		theFail.SetActive(false);
		theCorrect.SetActive(false);
		thePlace = 0;
		playerNotes ="";
	}

	public void ClosePiano(){
		thePiano.SetActive(false);
		theFail.SetActive(false);
		theCorrect.SetActive(false);
		thePlace = 0;
		playerNotes ="";
	}

	public void TryAgain(){
		theFail.SetActive(false);
		theCorrect.SetActive(false);
		thePlace = 0;
		playerNotes ="";
	}

	void CheckTune(){
		if (playerNotes == theNotes){
			theCorrect.SetActive(true);
			Debug.Log("You solved the Piano!");
			Vector3 shiftPos = new Vector3(0, 1, 0);
			Instantiate (theLoot, (drawerPos.position - shiftPos), Quaternion.identity);
			drawerLocked.SetActive(false);
			drawerOpened.SetActive(true);
		} else {
			theFail.SetActive(true);
		}
	}

	//these functions get added to each button / piano key
	public void noteC1(){
		keyC1.Play();
		playerNotes = playerNotes + "c";
		thePlace += 1;
		if (thePlace >= notesLength){ CheckTune(); }
	}

	public void noteD(){
		keyD.Play();
		playerNotes = playerNotes + "d";
		thePlace += 1;
		if (thePlace >= notesLength){ CheckTune(); }
	}

	public void noteE(){
		keyE.Play();
		playerNotes = playerNotes + "e";
		thePlace += 1;
		if (thePlace >= notesLength){ CheckTune(); }
	}

	public void noteF(){
		keyF.Play();
		playerNotes = playerNotes + "f";
		thePlace += 1;
		if (thePlace >= notesLength){ CheckTune(); }
	}

	public void noteG(){
		keyG.Play();
		playerNotes = playerNotes + "g";
		thePlace += 1;
		if (thePlace >= notesLength){ CheckTune(); }
	}

	public void noteA(){
		keyA.Play();;
		playerNotes = playerNotes + "a";
		thePlace += 1;
		if (thePlace >= notesLength){ CheckTune(); }
	}

	public void noteB(){
		keyB.Play();
		playerNotes = playerNotes + "b";
		thePlace += 1;
		if (thePlace >= notesLength){ CheckTune(); }
	}

	public void noteC2(){
		keyC2.Play();
		playerNotes = playerNotes + "h";
		thePlace += 1;
		if (thePlace >= notesLength){ CheckTune(); }
		//yes, I know there is no "h" key on the piano, but we needed a unique letter
	}

}

//Apply this script to the GameHandler or canvas
//Populate all gameObject and AudioSource slots
//populater the piano position slot with the piano object
//decide theNotes (remember, c2 = h)
