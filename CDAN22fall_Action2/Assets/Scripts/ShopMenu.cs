using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEngine.Audio;

//not using this script

public class ShopMenu : MonoBehaviour{

      public GameHandler gameHandler;
      public static bool ShopisOpen = false;
      public GameObject shopMenuUI;
      public GameObject leaveButton;

      public GameObject item1BuyButton;
      public GameObject item2BuyButton;
      public GameObject item3BuyButton;

      public int item1Cost = 3;
      public int item2Cost = 4;
      public int item3Cost = 5;

      public string NextLevel;
      //public AudioSource KaChingSFX;


      void Start (){
        shopMenuUI.SetActive(true);
            gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
      }

      void Update (){
            if ((GameHandler.gotButtons >= item1Cost) && (GameHandler.gotitem1 == false)) {
                        item1BuyButton.SetActive(true);}
            else { item1BuyButton.SetActive(false);}

            if ((GameHandler.gotButtons >= item2Cost) && (GameHandler.gotitem2 == false)) {
                        item2BuyButton.SetActive(true);}
            else { item2BuyButton.SetActive(false);}

            if ((GameHandler.gotButtons >= item3Cost) && (GameHandler.gotitem3 == false)) {
                        item3BuyButton.SetActive(true);}
            else { item3BuyButton.SetActive(false);}
      }

      //Button Functions:

      public void Button_CloseShop(){
        SceneManager.LoadScene(NextLevel);
      }

      public void Button_BuyItem1(){
            gameHandler.playerGetButtons((item1Cost * -1));
            GameHandler.gotitem1 = true;
            //KaChingSFX.Play();
      }

      public void Button_BuyItem2(){
            gameHandler.playerGetButtons((item2Cost * -1));
            GameHandler.gotitem2 = true;
            //KaChingSFX.Play();
      }

      public void Button_BuyItem3(){
            gameHandler.playerGetButtons((item3Cost * -1));
            GameHandler.gotitem3 = true;
            //KaChingSFX.Play();
      }
}
