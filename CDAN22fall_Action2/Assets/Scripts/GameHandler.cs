using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour {

      private GameObject player;
      public static int playerHealth = 100;
      public int StartPlayerHealth = 100;
      public GameObject healthText;

      public static int gotTokens = 0;
      public GameObject tokensText;

      public bool isDefending = false;

      public static bool stairCaseUnlocked = false;
      //this is a flag check. Add to other scripts: GameHandler.stairCaseUnlocked = true;

      private string sceneName;

// puzzle variables:
      public static bool escapedRoom1;
      public static bool hasFoundPaper;
      public static bool hasFoundKey;
      public static bool hasFoundLadder;

      void Start(){
            player = GameObject.FindWithTag("Player");
            sceneName = SceneManager.GetActiveScene().name;
            //if (sceneName=="MainMenu"){ //uncomment these two lines when the MainMenu exists
                  playerHealth = StartPlayerHealth;
            //}
            updateStatsDisplay();
      }

      public void playerGetTokens(int newTokens){
            gotTokens += newTokens;
            updateStatsDisplay();
      }

      public void playerGetHit(int damage){
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

      public void updateStatsDisplay(){
            Text healthTextTemp = healthText.GetComponent<Text>();
            healthTextTemp.text = "HEALTH: " + playerHealth;

            Text tokensTextTemp = tokensText.GetComponent<Text>();
            tokensTextTemp.text = "GOLD: " + gotTokens;
      }

      public void playerDies(){
            player.GetComponent<PlayerHurt>().playerDead();       //play Death animation
            StartCoroutine(DeathPause());
      }

      IEnumerator DeathPause(){
            player.GetComponent<PlayerMoveAround>().isAlive = false;
            yield return new WaitForSeconds(1.0f);
            SceneManager.LoadScene("EndLose");
      }

      public void StartGame() {
            SceneManager.LoadScene("Level1Bedroom");
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
}
