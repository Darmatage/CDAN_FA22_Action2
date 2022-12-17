using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueRollover : MonoBehaviour{
    
	public GameObject myClue;
	

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.tag == "Player"){
			myClue.SetActive(true);
		}
    }
	
	void OnTriggerExit2D(Collider2D other)
    {
		if (other.gameObject.tag == "Player"){
			myClue.SetActive(false);
		}
    }
	
	
}
