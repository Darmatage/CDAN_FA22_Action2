using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningCutscene_Script : MonoBehaviour{

  public int primeInt = 1;
  public GameObject textBoxDisplay;
  public GameObject nextButton;

  public string textBoxText;
  private bool allowSpace = true;
  //private bool isEndofScene = false;

    // Start is called before the first frame update
    void Start(){
        textBoxDisplay.SetActive(true);
        nextButton.SetActive(true);

      if (allowSpace==true){
        if(Input.GetKeyDown("space")){
          talking();
        }
      }
      }

  public void talking(){
    primeInt = primeInt + 1;

    if (primeInt==1){
    }
      else if (primeInt==2){
        //textBoxText = "I've been inside these walls too long now.";
      }
      else if (primeInt==3){
        //textboxText = "I want to venture out and see the world.";
      }
      else if (primeInt==4){
        //textboxText = "But first, I have to find a way outside this house.";
      }
      else if (primeInt==5){
        //textboxText = "Alright. ... ";
      }
      else if (primeInt==5){
        //textboxText = "Here I go.";

        //isEndofScene=true;
        //LoadScene();
      }
  }

  //public void LoadScene(){
    //SceneManager.LoadScene(Level1Bedroom_new);
  }
