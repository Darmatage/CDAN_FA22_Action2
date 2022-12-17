using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Audio;

public class GameShop : MonoBehaviour{
		
	//SHOP VARIABLES
	public GameObject shopMenu;
	public bool shopIsOpen = false;

	public GameObject shopItem1Button;
	public GameObject shopItem2Button;
	public GameObject shopItem3Button;
	
	public int item1cost = 5;
	public int item2cost = 10;
	public int item3cost = 20;
	
	
	public GameObject clue1;
	public GameObject clue2;
	public GameObject clue3;
	
	//public AudioSource KaChingSFX;
	
	void Start(){

		//shop visibility
		shopMenu.SetActive(false);
		
		//clue vsiibility
		clue1.SetActive(false);
		clue2.SetActive(false);
		clue3.SetActive(false);
	}

	void Update(){
		//open shop:
		//if ((GameTracking.isShop)&&(Input.GetKeyDown("e"))){
		if (Input.GetKeyDown("e")){
			Debug.Log("I hit [e]. shopIsOpen = " + shopIsOpen);
			shopIsOpen = !shopIsOpen;
		}
		
		if (shopIsOpen){shopMenu.SetActive(true);}
		else {shopMenu.SetActive(false);}
		
		//set button purchase visibility:
		if ((item1cost <= GameHandler.gotButtons)&&(GameTracking.gotClue1==false)){
			shopItem1Button.SetActive(true);
		} else {shopItem1Button.SetActive(false);}
		
		if ((item2cost <= GameHandler.gotButtons)&&(GameTracking.gotClue2==false)){
			shopItem2Button.SetActive(true);
		} else {shopItem2Button.SetActive(false);}
		
		if ((item3cost <= GameHandler.gotButtons)&&(GameTracking.gotClue3==false)){
			shopItem3Button.SetActive(true);
		} else {shopItem3Button.SetActive(false);}
		
		
		//set clue visibility:
		if (GameTracking.gotClue1) {clue1.SetActive(true);} else {clue1.SetActive(false);}
		if (GameTracking.gotClue2) {clue2.SetActive(true);} else {clue2.SetActive(false);}
		if (GameTracking.gotClue3) {clue3.SetActive(true);} else {clue3.SetActive(false);}
		
		
		//Cheat code:
		if (Input.GetKeyDown("]")){
			gameObject.GetComponent<GameHandler>().playerGetButtons(40);
		}
		
	}
	
	 //Button Functions:
	public void BuyItem1(){
		GameTracking.gotClue1 = true;
		int spentButtons = (item1cost * -1);
		gameObject.GetComponent<GameHandler>().playerGetButtons(spentButtons);
		//KaChingSFX.Play();
	}
	
	public void BuyItem2(){
		GameTracking.gotClue2 = true;
		int spentButtons = (item1cost * -1);
		gameObject.GetComponent<GameHandler>().playerGetButtons(spentButtons);
		//KaChingSFX.Play();
	}
	
	public void BuyItem3(){
		GameTracking.gotClue3 = true;
		int spentButtons = (item1cost * -1);
		gameObject.GetComponent<GameHandler>().playerGetButtons(spentButtons);
		//KaChingSFX.Play();
	}
	
	public void CloseShop(){
		shopMenu.SetActive(false);
		shopIsOpen = false;
	}
	
}
