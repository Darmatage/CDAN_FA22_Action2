using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopFloorExit : MonoBehaviour{

  public BoxCollider2D collider1;

  public static bool finishedAllPuzzles=false;

void Start(){
  collider1.gameObject.GetComponent<BoxCollider2D>().enabled = true;
}

public void AccessingDownstairs(){

  				if ((GameTracking.escapedRoom1)&&(GameTracking.escapedRoom2)&&(GameTracking.escapedRoom3)){
  					finishedAllPuzzles=true;
  				}
          if(finishedAllPuzzles==true){
            collider1.gameObject.GetComponent<BoxCollider2D>().enabled = false;
          }
  			}

}
