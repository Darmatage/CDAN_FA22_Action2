using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorExitSimple : MonoBehaviour{

    public string NextLevel;


	public GameObject doorOpen;
	public GameObject doorClosed;
	public GameObject shopEntrance; //these were private, so they could not be filled...? why here at all?
	public GameObject bathroomDoor; //these were private, so they could not be filled...? why here at all?
	public GameObject siblingRoomDoor; //these were private, so they could not be filled...? why here at all?
	//private GameObject shopEntrance;
	public bool canEnter=false;



	void Start(){
		doorOpen.SetActive(false);
		doorClosed.SetActive(true);
		shopEntrance.SetActive(true);
		bathroomDoor.SetActive(false);
		siblingRoomDoor.SetActive(false);
	}

	void Update(){
		if (GameTracking.isRoom1){
			if(GameTracking.hasFoundKey1){
				canEnter=true;
			}else {canEnter=false;}
		}

		if (GameTracking.isHallway){
			canEnter=true;
			bathroomDoor.SetActive(true);
			siblingRoomDoor.SetActive(true);
			doorClosed.SetActive(false);
			doorOpen.SetActive(true);
		}else{
			canEnter=false;
			GameTracking.isRoom2=false; //why are these here?
			GameTracking.isRoom3=false;
			}

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
