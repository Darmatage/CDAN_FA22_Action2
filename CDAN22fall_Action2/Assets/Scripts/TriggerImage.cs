using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerImage : MonoBehaviour{

  public GameHandler GameTracking;
  public GameObject item;
  public GameObject image;
  public bool playerInRange = false;

    // Start is called before the first frame update
    void Start(){
      image.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other){
      if (other.gameObject.tag == "Player"){
        playerInRange=true;
        image.SetActive(true);
          }
    }

    private void OnTriggerExit2D (Collider2D other){
      if (other.gameObject.tag == "Player"){
        playerInRange=false;
        image.SetActive(false);
    }
  }
}
