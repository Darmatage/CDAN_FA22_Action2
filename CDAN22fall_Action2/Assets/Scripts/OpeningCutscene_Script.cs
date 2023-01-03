using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpeningCutscene_Script : MonoBehaviour{

  public int primeInt = 1;
  public GameObject textBoxDisplay;
  public GameObject nextButton;
  public GameObject nextSceneButton;

  public Text OpeningText;
  private bool allowSpace = true;
  //private bool isEndofScene = false;

    // Start is called before the first frame update
    void Start(){
        textBoxDisplay.SetActive(true);
        nextButton.SetActive(true);
        nextSceneButton.SetActive(false);

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
        //StartCoroutine(TypeText(OpeningText.text, "(I've been inside these walls too long now.)"));
        OpeningText.text = "(I've been inside these walls too long now.)";
      }
      else if (primeInt==3){
        //StartCoroutine(TypeText(OpeningText.text, "(I want to venture out and see the world.)"));
        OpeningText.text = "(I want to venture out and see the world.)";
      }
      else if (primeInt==4){
        //StartCoroutine(TypeText(OpeningText.text, "(But first, I have to find a way outside this house.)"));
        OpeningText.text = "(But first, I have to find a way outside this house.)";
      }
      else if (primeInt==5){
        //StartCoroutine(TypeText(OpeningText.text, "(Alright. ... )"));
        OpeningText.text = "(Alright. ... )";
      }
      else if (primeInt==6){
        //StartCoroutine(TypeText(OpeningText.text, "(Here I go.)"));
        OpeningText.text = "(Here I go.)";
      }
      else if (primeInt==7){
        OpeningText.text = "(Here I go.)";

        nextButton.SetActive(false);
        nextSceneButton.SetActive(true);
        //isEndofScene=true;
        allowSpace=false;
        //isEndofScene=true;
        LoadScene();
      }
  }

  public void LoadScene(){
    SceneManager.LoadScene("Level1Bedroom_new");
  }

  //IEnumerator TypeText(Text target, string fullText){
             //float delay = 0.01f;
             //nextButton.SetActive(false);
             //allowSpace = false;
             //for (int i = 0; i < fullText.Length; i++){
                     //string currentText = fullText.Substring(0,i);
                     //target.text = currentText;
                     //yield return new WaitForSeconds(delay);
             //}
           //}
}
