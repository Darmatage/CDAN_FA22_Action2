using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearManager : MonoBehaviour
{
	//bear amanagement stuff
	public TextBoxManager textBoxMngr;
	public GameObject bearAsleep;
	public GameObject bearAttack;
	public GameObject bearPure;
	public GameObject soulParticles;
	
	public bool touchedBear = false;
	public bool isAwake = false;
	public bool isPurified = false;
	public bool canPurify = false;
	
	public GameObject lootDrop;
	
	public BoxCollider2D collider1;
	public BoxCollider2D collider2;
	public BoxCollider2D collider3;

	
	void Awake(){
		gameObject.GetComponent<EnemyMoveHit>().enabled = false;
		
	}
	
    void Start(){
        textBoxMngr = GameObject.FindWithTag("ButtonTriggerManager").GetComponent<TextBoxManager>();
		bearAsleep.SetActive(true);
		bearAttack.SetActive(false);
		bearPure.SetActive(false);
		gameObject.GetComponent<EnemyMoveHit>().enabled = false;	
    }

    void Update()
    {
        if ((textBoxMngr.doEvent == true)&&(isPurified == false)){
			isAwake = true;
		}
		
		if (isAwake==true){
			bearAsleep.SetActive(false);
			bearAttack.SetActive(true);
			bearPure.SetActive(false);
			gameObject.GetComponent<EnemyMoveHit>().enabled = true;	
		}
		
		if (isPurified == true){
			isAwake = false;
			bearAsleep.SetActive(false);
			//bearAttack.SetActive(false);
			//bearPure.SetActive(true);
			bearAsleep.GetComponent<TextBoxText>().enabled = false;
			gameObject.GetComponent<EnemyMoveHit>().enabled = false;
			collider1.enabled = false;
			collider2.enabled = false;
			collider3.enabled = false;
		}
		
		if ((GameInventory.item2bool)&&(GameInventory.item3bool)&&(GameInventory.item4bool)){
			canPurify = true;
		}
    }
	
	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag=="Player"){
			textBoxMngr.atEvent = true;
		}
		
		if ((other.gameObject.tag=="pentagram")&&(canPurify)){
			isPurified = true;
			GameObject particleSys = Instantiate (soulParticles, transform.position, Quaternion.identity);
            StartCoroutine(destroyParticles(particleSys));
		}
		
	}
	
	IEnumerator destroyParticles(GameObject pSys){
		bearAttack.SetActive(true);
		bearPure.SetActive(false);
			  yield return new WaitForSeconds(0.5f);
		bearAttack.SetActive(false);
		bearPure.SetActive(true);
			  yield return new WaitForSeconds(0.5f);
		bearAttack.SetActive(true);
		bearPure.SetActive(false);	  
			  yield return new WaitForSeconds(0.5f);
		bearAttack.SetActive(false);
		bearPure.SetActive(true);
			  
		Instantiate (lootDrop, transform.position, Quaternion.identity);
		
			yield return new WaitForSeconds(2.5f);
		Destroy(pSys);
	}
	
}
