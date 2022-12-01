using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PickUp : MonoBehaviour{

      public GameHandler gameHandler;
	  public GameTracking gameTracking;
      //public GameObject TextBox;
      //public playerVFX playerPowerupVFX;
      public bool isKey1 = false;
	  public bool isKey2 = false;

      void Start(){
            gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
			gameTracking = GameObject.FindWithTag("GameHandler").GetComponent<GameTracking>();
            //playerPowerupVFX = GameObject.FindWithTag("Player").GetComponent<playerVFX>();
      }

      public void OnTriggerEnter2D (Collider2D other){
            if (other.gameObject.tag == "Player"){
                  GetComponent<Collider2D>().enabled = false;
                  
				if (isKey1 == true){  
				  GameTracking.hasFoundKey1=true;
				  gameTracking.hasFoundKey1_test=true;
				}
				if (isKey2 == true){  
				  GameTracking.hasFoundKey2=true;
				}
				  
				  StartCoroutine(DestroyThis());
              }
          }

      IEnumerator DestroyThis(){
            yield return new WaitForSeconds(0.3f);
            Destroy(gameObject);
      }
  }
