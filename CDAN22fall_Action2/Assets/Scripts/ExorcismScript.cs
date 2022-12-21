using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExorcismScript : MonoBehaviour
{
	public GameObject pentUnlit;
	public GameObject pentLit;
	public bool haveAllSpellParts = false;
	public bool inPentagram = false;
	
	public GameObject bear;
	
	// public GameObject candle;
	// public GameObject chalk; 
	// public GameObject spell;
    
	// public bool hasCandle = false;
	// public bool hasChalk = false;
	// public bool hasSpell = false; 
	
	
    void Start(){
		pentUnlit.SetActive(true);
		pentLit.SetActive(false);
		// candle.SetActive(true);
		// chalk.SetActive(true);
		// spell.SetActive(true);
    }

    void Update(){
       // if the player has all three items
		if ((GameInventory.item2bool==true) && (GameInventory.item3bool==true) && (GameInventory.item4bool==true)){
			haveAllSpellParts = true;
		}
		
		if (inPentagram == true){
			StartExorcism();
		}
		
    }
	
	public void OnTriggerStay2D(Collider2D other){
		if ((other.gameObject.tag == "Player")&&(haveAllSpellParts==true)){
			pentUnlit.SetActive(false);
			pentLit.SetActive(true);
			inPentagram = true;
		}
	}
	
	public void OnTriggerExit2D(Collider2D other){
		if ((other.gameObject.tag == "Player")&&(haveAllSpellParts==true)){
			pentUnlit.SetActive(true);
			pentLit.SetActive(false);
			inPentagram = false;
			StopExorcism();
		}
	}
	
	public void StartExorcism(){
		bear.GetComponent<EnemyMoveHit>().attackRange = 50;
		bear.GetComponent<EnemyMoveHit>().target = GameObject.FindWithTag("pentagram").GetComponent<Transform>();
		
	}
	
	public void StopExorcism(){
		bear.GetComponent<EnemyMoveHit>().attackRange = 10;
		bear.GetComponent<EnemyMoveHit>().target = GameObject.FindWithTag("Player").GetComponent<Transform>();
		
	}
	
}
