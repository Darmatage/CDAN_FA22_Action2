using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour{

      private GameObject player;
      public static int playerHealth = 100;
      public int StartPlayerHealth = 100;
      public GameObject healthDisplay;
      public GameObject healthText;

      public static int gotButtons = 0;
      public GameObject buttonDisplay;
      public GameObject buttonsText;

      public bool isDefending = false;
      public bool canHealth = true;
      public bool canButton = true;


      public static bool stairCaseUnlocked = false;
      //this is a flag check. Add to other scripts: GameHandler.stairCaseUnlocked = true;

      private string sceneName;

// puzzle variables:
      public static bool escapedRoom1;
      public static bool hasFoundPaper;
      public static bool hasFoundKey;
      public static bool hasFoundLadder;

      void Start(){
        if(canHealth==false){
          healthDisplay.SetActive(false);
        }
        if (canButton==false){
          buttonDisplay.SetActive(false);
        }

            player = GameObject.FindWithTag("Player");
            sceneName = SceneManager.GetActiveScene().name;
            //if (sceneName=="MainMenu"){ //uncomment these two lines when the MainMenu exists
                  playerHealth = StartPlayerHealth;
            //}
            updateStatsDisplay();
      }

      public void playerGetButtons(int newButton){
        if(canButton){
            gotButtons += newButton;
            updateStatsDisplay();
        }
      }

      public void playerGetHit(int damage){
        if(canHealth){
           if (isDefending == false){
                  playerHealth -= damage;
                  if (playerHealth >=0){
                        updateStatsDisplay();
                  }
                  if (damage > 0){
                        player.GetComponent<PlayerHurt>().playerHit();       //play GetHit animation
                  }
               }

           if (playerHealth > StartPlayerHealth){
                  playerHealth = StartPlayerHealth;
                  updateStatsDisplay();
            }

           if (playerHealth <= 0){
                  playerHealth = 0;
                  updateStatsDisplay();
                  playerDies();
            }
         }
      }

      public void updateStatsDisplay(){
            Text healthTextTemp = healthText.GetComponent<Text>();
            healthTextTemp.text = "HEALTH: " + playerHealth;

            Text buttonsTextTemp = buttonsText.GetComponent<Text>();
            buttonsTextTemp.text = "" + gotButtons;
      }

      public void playerDies(){
            player.GetComponent<PlayerHurt>().playerDead();       //play Death animation
            StartCoroutine(DeathPause());
      }

      IEnumerator DeathPause(){
            player.GetComponent<PlayerMoveAround>().isAlive = false;
            yield return new WaitForSeconds(1.0f);
            SceneManager.LoadScene("LoseScreen");
      }

      public void StartGame() {
            SceneManager.LoadScene("OpeningCutscene");
      }

      public void RestartGame() {
            SceneManager.LoadScene("MainMenu");
            playerHealth = StartPlayerHealth;
      }

      public void QuitGame() {
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
      }

      public void Credits() {
            SceneManager.LoadScene("Credits");
      }
     public static bool gotitem1 = false;
     public static bool gotitem2 = false;
     public static bool gotitem3 = false;
   }
