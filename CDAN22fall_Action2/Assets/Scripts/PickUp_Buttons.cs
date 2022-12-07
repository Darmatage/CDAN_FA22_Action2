using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_Buttons : MonoBehaviour{

  public GameHandler gameHandler;
  public GameObject buttonArt;
  public GameObject buttonsText;

  private string buttonsDisplayText;

  public static int gotButton = 0;

  void Start(){
    gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
  }

  public void OnTriggerEnter2D (Collider2D other){
            if (other.gameObject.tag == "Player"){
                  GetComponent<Collider2D>().enabled = false;
                  //GetComponent<AudioSource>().Play();
                  StartCoroutine(DestroyThis());
      }
    }
      IEnumerator DestroyThis(){
            yield return new WaitForSeconds(0.3f);
            Destroy(gameObject);
    }
    public void playerGetButtons(int newButton){
          gotButton += newButton;
          updateStatsDisplay();
    }
    public void updateStatsDisplay(){
          buttonsDisplayText= "" + gotButton;
    }

}
