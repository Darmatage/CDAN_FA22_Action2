using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorExitSimple : MonoBehaviour{

    public string NextLevel;


	public GameObject doorOpen;
	public GameObject doorClosed;
	public bool canEnter=false;



	void Start(){
		doorOpen.SetActive(false);
		doorClosed.SetActive(true);
	}

	void Update(){

// hallway

		if (GameTracking.isHallway){
			canEnter=true;
		}

// room 1

		if (GameTracking.isRoom1){
			if(GameTracking.hasFoundLadder1){
				canEnter=true;
			}else {canEnter=false;}
		}

// room 2

		if (GameTracking.isRoom2){
			if(GameTracking.hasFoundKey2){
				canEnter=true;
			} else {canEnter=false;}
		}

		if (canEnter==true){
			doorOpen.SetActive(true);
			doorClosed.SetActive(false);
		} else {
			doorOpen.SetActive(false);
			doorClosed.SetActive(true);
		}

	}


    public void OnTriggerEnter2D(Collider2D other){
        if ((other.gameObject.tag == "Player")&&(canEnter)){
            SceneManager.LoadScene(NextLevel);
        }
    }

}
