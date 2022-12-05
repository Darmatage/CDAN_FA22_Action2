using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_new : MonoBehaviour{

  public GameObject chestOpen;
  public GameObject chestClosed;
  public GameObject chestContents;
  public GameHandler gameHandler;
  public static bool isButtonPickUp=false;
  public bool canEnter=false;

    // Start is called before the first frame update
    void Start(){

// room 1
    GameTracking.hasFoundKey1=false;
    GameTracking.hasFoundLadder1=false;
    if (GameTracking.isRoom1==true){
      chestOpen.SetActive(false);
      chestClosed.SetActive(true);
      chestContents.SetActive(false);
    }
  }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other){
      if(other.gameObject.tag=="Player"){
        GetComponent<Collider2D>().enabled = false;
        StartCoroutine(DestroyThis());

// room 1

    if(GameTracking.isRoom1==true){
      if(GameTracking.hasFoundKey1==true){
        chestOpen.SetActive(true);
        chestClosed.SetActive(false);
        chestContents.SetActive(true);
          GameTracking.hasFoundLadder1=true;
      }
    }
    if(GameTracking.isRoom1==true){
      if(GameTracking.hasFoundLadder1==true){
        canEnter=true;
      }
    }
  }
}


    IEnumerator DestroyThis(){
             yield return new WaitForSeconds(0.2f);
             Destroy(gameObject);
    }
  }
