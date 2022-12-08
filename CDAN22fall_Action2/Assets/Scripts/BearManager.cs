using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearManager : MonoBehaviour
{
	//bear amanagement stuff
	public TextBoxManager textBoxMngr;
	public GameObject bearAsleep;
	public GameObject bearAttack;
	
	public bool touchedBear = false;
	public bool isAwake = false;
	public bool isPurified = false;
	
	void Awake(){
		gameObject.GetComponent<EnemyMoveHit>().enabled = false;
		
	}
	
    void Start(){
        textBoxMngr = GameObject.FindWithTag("ButtonTriggerManager").GetComponent<TextBoxManager>();
		bearAsleep.SetActive(true);
		bearAttack.SetActive(false);
    }

    void Update()
    {
        if (textBoxMngr.doEvent == true){
			bearAsleep.SetActive(false);
			bearAttack.SetActive(true);
			isAwake = true;
		}
		
		if (isAwake==true){
			gameObject.GetComponent<EnemyMoveHit>().enabled = true;
			
		}
		
    }
	
	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag=="Player"){
			textBoxMngr.atEvent = true;
		}
		
		if (other.gameObject.tag=="pentagram"){
			isPurified = true;
		}
		
	}
	
	
	
}
