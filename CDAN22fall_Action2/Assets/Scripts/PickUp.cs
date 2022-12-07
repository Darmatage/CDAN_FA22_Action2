using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PickUp : MonoBehaviour{

      public void OnTriggerEnter2D (Collider2D other){
            if (other.gameObject.tag == "Player"){
                  GetComponent<Collider2D>().enabled = false;
                  //GetComponent<AudioSource>().Play();
                  StartCoroutine(DestroyThis());
// room 1
                if (GameTracking.isRoom1==true){
                  GameTracking.hasFoundLadder1=true;
                }
            }
      }

      IEnumerator DestroyThis(){
            yield return new WaitForSeconds(0.3f);
            Destroy(gameObject);
      }

}
