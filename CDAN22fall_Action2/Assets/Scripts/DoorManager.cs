using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
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
		}
    }
	
}
