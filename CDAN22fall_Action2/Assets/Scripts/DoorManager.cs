using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour{
	public GameObject noLadder;
	public GameObject gotLadder;
	
    void Start(){
        noLadder.SetActive(true);
		gotLadder.SetActive(false);
    }


    public void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "ladder"){
			noLadder.SetActive(false);
			gotLadder.SetActive(true);

			other.gameObject.GetComponent<BoxCollider2D>().enabled = false;
			//GameTracking.hasFoundLadder1 = true;

		// room 1
			if (GameTracking.isRoom1){
				GameTracking.escapedRoom1=true;
			}
		
		// room 2
			if (GameTracking.isRoom2){
				GameTracking.escapedRoom2=true;
			}
		
		// room 3
			if (GameTracking.isRoom3){
				GameTracking.escapedRoom3=true;
			}
		
		// room 4
			if (GameTracking.isRoom4){
				GameTracking.escapedRoom4=true;
			}
		
		// room 5
			if (GameTracking.isRoom5){
				GameTracking.escapedRoom5=true;
			}
		}			
	}

}
