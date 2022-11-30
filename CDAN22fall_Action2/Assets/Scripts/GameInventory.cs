using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameInventory : MonoBehaviour {
      public GameObject InventoryMenu;
      //public GameObject CraftMenu;
      public bool InvIsOpen = false;

      //5 Inventory Items:
      public static bool item1bool = false;
      public static bool item2bool = false;
      public static bool item3bool = false;
      public static bool item4bool = false;
      public static bool item5bool = false;
//<<<<<<< HEAD:CDAN22fall_Action2/Assets/Scenes/Scripts/GameInventory.cs
      public static int coins = 0;
//=======
      //public static int coins = 0;
//>>>>>>> 2f1081769f1b76423f06eaa0acc79d3fc771e952:CDAN22fall_Action2/Assets/Scripts/GameInventory.cs

      public static int item1num = 0;
      public static int item2num = 0;
      public static int item3num = 0;
      public static int item4num = 0;
      public static int item5num = 0;

      public GameObject item1image;
      public GameObject item2image;
      public GameObject item3image;
      public GameObject item4image;
      public GameObject item5image;
//<<<<<<< HEAD:CDAN22fall_Action2/Assets/Scenes/Scripts/GameInventory.cs
      public GameObject coinText;
//=======


	  public Text item1Text;
	  public Text item2Text;
	  public Text item3Text;
	  public Text item4Text;
	  public Text item5Text;
	  //public GameObject coinText;

//>>>>>>> 2f1081769f1b76423f06eaa0acc79d3fc771e952:CDAN22fall_Action2/Assets/Scripts/GameInventory.cs

      void Start(){
            InventoryMenu.SetActive(true);
            //CraftMenu.SetActive(false);
            InventoryDisplay();
      }

      void InventoryDisplay(){
            if (item1bool == true) {item1image.SetActive(true);} else {item1image.SetActive(false);}
            if (item2bool == true) {item2image.SetActive(true);} else {item2image.SetActive(false);}
            if (item3bool == true) {item3image.SetActive(true);} else {item3image.SetActive(false);}
            if (item4bool == true) {item4image.SetActive(true);} else {item4image.SetActive(false);}
            if (item5bool == true) {item5image.SetActive(true);} else {item5image.SetActive(false);}

//<<<<<<< HEAD:CDAN22fall_Action2/Assets/Scenes/Scripts/GameInventory.cs
            Text coinTextB = coinText.GetComponent<Text>();
            coinTextB.text = ("COINS: " + coins);
//=======
            //Text coinTextB = coinText.GetComponent<Text>();
            //coinTextB.text = ("COINS: " + coins);
//>>>>>>> 2f1081769f1b76423f06eaa0acc79d3fc771e952:CDAN22fall_Action2/Assets/Scripts/GameInventory.cs
      }

      public void InventoryAdd(string item){
            string foundItemName = item;
            if (foundItemName == "item1") {item1bool = true; item1num ++;}
            else if (foundItemName == "item2") {item2bool = true; item2num ++;}
            else if (foundItemName == "item3") {item3bool = true; item3num ++;}
            else if (foundItemName == "item4") {item4bool = true; item4num ++;}
            else if (foundItemName == "item5") {item5bool = true; item5num ++;}
            else { Debug.Log("This item does not exist to be added"); }
            InventoryDisplay();

            if (!InvIsOpen){
                  OpenCloseInventory();
            }
      }

      public void InventoryRemove(string item, int num){
            string itemRemove = item;
            if (itemRemove == "item1") {
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
            else { Debug.Log("This item does not exist to be removed"); }
            InventoryDisplay();
      }

//<<<<<<< HEAD:CDAN22fall_Action2/Assets/Scenes/Scripts/GameInventory.cs
      public void CoinChange(int amount){
            coins +=amount;
            InventoryDisplay();
      }
//=======
      //public void CoinChange(int amount){
            //coins +=amount;
            //InventoryDisplay();
      //}
//>>>>>>> 2f1081769f1b76423f06eaa0acc79d3fc771e952:CDAN22fall_Action2/Assets/Scripts/GameInventory.cs

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

            item1num = 0; // name
            item2num = 0; // name
            item3num = 0; // name
            item4num = 0; // name
            item5num = 0; // name
      }

//<<<<<<< HEAD:CDAN22fall_Action2/Assets/Scenes/Scripts/GameInventory.cs
}
//=======
//}
//>>>>>>> 2f1081769f1b76423f06eaa0acc79d3fc771e952:CDAN22fall_Action2/Assets/Scripts/GameInventory.cs
