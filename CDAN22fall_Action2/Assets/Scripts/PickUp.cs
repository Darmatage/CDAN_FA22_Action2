using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PickUp : MonoBehaviour{

      public GameHandler gameHandler;
      public GameObject TextBox;
      //public playerVFX playerPowerupVFX;
      public bool hasFoundKey1;

      void Start(){
            gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
            //playerPowerupVFX = GameObject.FindWithTag("Player").GetComponent<playerVFX>();
            GameTracking.hasFoundKey1=false;
      }

      public void OnTriggerEnter2D (Collider2D other){
            if (other.gameObject.tag == "Player"){
                  GetComponent<Collider2D>().enabled = false;
                  StartCoroutine(DestroyThis());

                  if (GameTracking.hasFoundKey1 == true) {
                      TextBox.SetActive(true);
                      GameTracking.hasFoundKey1=true;
                  }

            }
      }

      IEnumerator DestroyThis(){
            yield return new WaitForSeconds(0.3f);
            Destroy(gameObject);
      }

}
