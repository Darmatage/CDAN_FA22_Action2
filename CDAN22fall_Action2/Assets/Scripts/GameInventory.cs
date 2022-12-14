using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameInventory : MonoBehaviour {
      public GameObject InventoryMenu;
      // Crafting buttons:
      public GameObject buttonCraft1; // weapon1 creation
      //public GameObject CraftMenu;
      public bool InvIsOpen = false;

      //5 Inventory Items:
      public static bool item1bool = false; //key1(room1 bedroom)
      public static bool item2bool = false; //chalk(room3 sibling)
      public static bool item3bool = false; //candle(room3)
      public static bool item4bool = false; //spell(room3)
      public static bool item5bool = false; //nailpolish (room5 livingroom)	  
	  public static bool item6bool = false; //key2 (room5)	
	  public static bool item7bool = false; //key3(room3)
	  
      public static int coins = 0;

      public static int item1num = 0;
      public static int item2num = 0;
      public static int item3num = 0;
      public static int item4num = 0;
      public static int item5num = 0;
	  public static int item6num = 0;
	  public static int item7num = 0;

      public GameObject item1image;
      public GameObject item2image;
      public GameObject item3image;
      public GameObject item4image;
      public GameObject item5image;
	  public GameObject item6image;
	  public GameObject item7image;
	  
	  public Text item1Text;
	  public Text item2Text;
	  public Text item3Text;
	  public Text item4Text;
	  public Text item5Text;
	  public Text item6Text;
	  public Text item7Text;
	  //public Text coinText;

      void Start(){
            InventoryMenu.SetActive(false);
            buttonCraft1.SetActive(false);
            //CraftMenu.SetActive(false);
            InventoryDisplay();
      }

      void InventoryDisplay(){
            if (item1bool == true) {item1image.SetActive(true);} else {item1image.SetActive(false);}
            if (item2bool == true) {item2image.SetActive(true);} else {item2image.SetActive(false);}
            if (item3bool == true) {item3image.SetActive(true);} else {item3image.SetActive(false);}
            if (item4bool == true) {item4image.SetActive(true);} else {item4image.SetActive(false);}
            if (item5bool == true) {item5image.SetActive(true);} else {item5image.SetActive(false);}
			if (item6bool == true) {item6image.SetActive(true);} else {item6image.SetActive(false);}
			if (item7bool == true) {item7image.SetActive(true);} else {item7image.SetActive(false);}

            //Text coinTextB = coinText.GetComponent<Text>();
            //coinTextB.text = ("COINS: " + coins);
			
			Text item1TextB = item1Text.GetComponent<Text>();
            item1TextB.text = ("" + item1num);
			
			Text item2TextB = item2Text.GetComponent<Text>();
            item2TextB.text = ("" + item2num);
			
			Text item3TextB = item3Text.GetComponent<Text>();
            item3TextB.text = ("" + item3num);
			
			Text item4TextB = item4Text.GetComponent<Text>();
            item4TextB.text = ("" + item4num);
			
			Text item5TextB = item5Text.GetComponent<Text>();
            item5TextB.text = ("" + item5num);
			
			Text item6TextB = item6Text.GetComponent<Text>();
            item6TextB.text = ("" + item6num);
			
			Text item7TextB = item7Text.GetComponent<Text>();
            item7TextB.text = ("" + item7num);
			
      }

      public void InventoryAdd(string item){
            string foundItemName = item;
            if (foundItemName == "key1") {item1bool = true; item1num ++;}
            else if (foundItemName == "item2") {item2bool = true; item2num ++;}
            else if (foundItemName == "item3") {item3bool = true; item3num ++;}
            else if (foundItemName == "item4") {item4bool = true; item4num ++;}
            else if (foundItemName == "item5") {item5bool = true; item5num ++;}
			else if (foundItemName == "item6") {item6bool = true; item6num ++;}
			else if (foundItemName == "item7") {item7bool = true; item7num ++;}

            else { Debug.Log("This item does not exist to be added"); }
            InventoryDisplay();

            if (!InvIsOpen){
                  OpenCloseInventory();
            }
			
			//crafting example
			 if ((item1num >= 2) && (item4num >= 1)){       // sample inventory items to be used
            buttonCraft1.SetActive(true);
			}
			else { buttonCraft1.SetActive(false); }
    }

      public void InventoryRemove(string item, int num){
            string itemRemove = item;
            if (itemRemove == "key1") {
                  item1num -= num;
                  if (item1num <= 0) { item1bool =false; }
                  // Add any other intended effects: new item crafted, speed boost, slow time, etc
             }
            else if (itemRemove == "item2") {
                  item2num -= num;
                  if (item2num <= 0) { item2bool =false; }
                  // Add any other intended effects
             }
            else if (itemRemove == "item3") {
                  item3num -= num;
                  if (item3num <= 0) { item3bool =false; }
                    // Add any other intended effects
            }
            else if (itemRemove == "item4") {
                  item4num -= num;
                  if (item4num <= 0) { item4bool =false; }
                    // Add any other intended effects
            }
            else if (itemRemove == "item5") {
                  item5num -= num;
                  if (item5num <= 0) { item5bool =false; }
                    // Add any other intended effects
            }
			else if (itemRemove == "item6") {
                  item6num -= num;
                  if (item6num <= 0) { item6bool =false; }
                    // Add any other intended effects
			}
			else if (itemRemove == "item7") {
                  item7num -= num;
                  if (item7num <= 0) { item7bool =false; }
                    // Add any other intended effects
            }
            else { Debug.Log("This item does not exist to be removed"); }
            InventoryDisplay();
			//crafting example
			 if ((item1num >= 2) && (item4num >= 1)){       // sample inventory items to be used
				buttonCraft1.SetActive(true);
			}
			else { buttonCraft1.SetActive(false); }
      }


      //public void CoinChange(int amount){
            //coins +=amount;
            //InventoryDisplay();
      //}

      // Open and Close the Inventory. Use this function on a button next to the inventory bar.
      public void OpenCloseInventory(){
            if (InvIsOpen){ InventoryMenu.SetActive(false); }
            else { InventoryMenu.SetActive(true); }
            InvIsOpen = !InvIsOpen;
      }

      //Open and Close the Cookbook
      //public void OpenCraftBook(){CraftMenu.SetActive(true);}
      //public void CloseCraftBook(){CraftMenu.SetActive(false);}

      // Reset all static inventory values on game restart.
      public void ResetAllInventory(){
            item1bool = false;
            item2bool = false;
            item3bool = false;
            item4bool = false;
            item5bool = false;
			item6bool = false;
			item7bool = false;


            item1num = 0; // key 1
            item2num = 0; // chalk
            item3num = 0; // candle
            item4num = 0; // spell
            item5num = 0; // nail polish
			item6num = 0; // key 2
			item7num = 0; //key 3 
      }

	//crafting function
	 public void CraftObject1(){
            InventoryAdd("weapon1"); // sample inventory item to be added, needs supporting UI images
            InventoryRemove("item1", 2); InventoryRemove("item4",1); // sample inventory items to be removed
      }

  }
