using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestManager : MonoBehaviour{

	public GameObject chestClosedObj;
	public GameObject chestOpenObj;

	public GameObject noKeyText;
	public GameObject hasKeyText;

	public GameObject chestLoot;

	private Color chestColor;
	public Color chestSetColor = new Color(2.55f, 2f, 1f, 1f);

	public bool chestOpen = false;
	public bool hasKey = false;
	public bool nearChest = false;

	public bool isLevel1 = true;
	public bool isLevel5 = false;

	private Vector3 shiftLoot;

    // Start is called before the first frame update
    void Start(){
		chestClosedObj.SetActive(true);
		chestOpenObj.SetActive(false);
		chestLoot.SetActive(false);
		noKeyText.SetActive(true);
		hasKeyText.SetActive(false);

		chestColor = chestClosedObj.GetComponent<SpriteRenderer>().color;
		
		shiftLoot = new Vector3(0,2,0);
    }

    // Update is called once per frame
    void Update(){

		//check to see if the key is in the inventory
		//set the "can open" text object active
		if ((GameInventory.item1bool==true)&&(chestOpen == false)&&(isLevel1)){
			hasKey=true;
			noKeyText.SetActive(false);
			hasKeyText.SetActive(true);
		}


		if ((GameInventory.item5bool==true)&&(chestOpen == false)&&(isLevel5)){
			hasKey=true;
			noKeyText.SetActive(false);
			hasKeyText.SetActive(true);
		}

		//if the player presses e and has the key
		//open the chest
		if ((Input.GetKeyDown("e"))&&(hasKey)&&(nearChest)){
			chestOpen = true;
			chestClosedObj.SetActive(false);
			chestOpenObj.SetActive(true);
			chestLoot.SetActive(true);
			//turn off messages
			noKeyText.SetActive(false);
			hasKeyText.SetActive(false);
			//drop the loot
		GameObject ladder = Instantiate (chestLoot, (transform.position + shiftLoot), Quaternion.identity);	
		ladder.SetActive(true);
            GetComponent<Collider2D>().enabled = false;

// room 1

		if (GameTracking.isRoom1==true){
			GameTracking.hasFoundLadder1=true;
		}

	}
}


	//NOTE: because the trigger boxcollider is on the child, this object gets a static rigidbody to see it
	public void OnTriggerEnter2D(Collider2D other){
		//Collider myCollider = other.GetContact(0).thisCollider;
		Debug.Log("I entered collider from parent");
		if (other.gameObject.tag == "Player"){
			nearChest = true;

			//flash a different color!
			SpriteRenderer chestRenderer = chestClosedObj.GetComponent<SpriteRenderer>();
			chestRenderer.color = chestSetColor;
		}
		else {nearChest = false;}
	}

	public void OnTriggerExit2D(Collider2D other){
		//Collider myCollider = other.GetContacts(0).thisCollider;
		Debug.Log("I exited collider from parent");
		nearChest = false;
		//return color to default
		SpriteRenderer chestRenderer = chestClosedObj.GetComponent<SpriteRenderer>();
		chestRenderer.color = chestColor;
	}

}
