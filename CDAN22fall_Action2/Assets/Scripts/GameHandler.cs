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

	public static bool gotitem1 = false;
	public static bool gotitem2 = false;
	public static bool gotitem3 = false;

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

	void Update(){
		makeLadderVisible();
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

//this function is because we do not know why the ladder prefab keeps getting turned off
	public void makeLadderVisible(){
		if (GameObject.FindWithTag("ladder") != null){
			GameObject.FindWithTag("ladder").SetActive(true);
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
		ResetStats();
		SceneManager.LoadScene("OpeningCutscene");
	}

	public void RestartGame() {
		ResetStats();
		SceneManager.LoadScene("MainMenu");
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

      public void Controls(){
        SceneManager.LoadScene("Controls");
      }
	  
	public void ResetStats(){
		gotButtons = 0;
		playerHealth = StartPlayerHealth;
		GameTracking.escapedRoom1 = false;
		GameTracking.escapedRoom2 = false;
		GameTracking.escapedRoom3 = false;
		GameTracking.escapedRoom5 = false;
		GameTracking.finalCodeSolved = false;
		GameTracking.recentRoom = "room1";
		
		GameTracking.gotClue1 = false;
		GameTracking.gotClue2 = false;
		GameTracking.gotClue3 = false;
		GameTracking.gotClue4 = false;
		
		GameInventory.item1bool = false;
		GameInventory.item2bool = false;
		GameInventory.item3bool = false;
		GameInventory.item4bool = false;
		GameInventory.item5bool = false;
		GameInventory.item6bool = false;
		GameInventory.item7bool = false;
		
		GameInventory.item1num = 0;
		GameInventory.item2num = 0;
		GameInventory.item3num = 0;
		GameInventory.item4num = 0;
		GameInventory.item5num = 0;
		GameInventory.item6num = 0;
		GameInventory.item7num = 0;
		
	  }
	  

   }
