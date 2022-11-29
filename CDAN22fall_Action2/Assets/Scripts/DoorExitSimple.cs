using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorExitSimple : MonoBehaviour{

    public string NextLevel = "Hallway";


	public GameObject doorOpen;
	public GameObject doorClosed;
	bool canEnter=false;

	

	void Start(){
		doorOpen.SetActive(false);
		doorClosed.SetActive(true);
	}

	void Update(){
		if (GameTracking.isRoom1){
			if(GameTracking.hasFoundKey1){
				canEnter=true;
			}else {canEnter=false;}
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
            SceneManager.LoadScene ("Hallway");
        }
    }

}
