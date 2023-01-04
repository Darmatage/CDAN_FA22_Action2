using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour {
	public int timer = 240;
	private float theTimer = 0f;
	public GameObject timerText;
	public bool canTimer = true;

	public GameObject timerTextObj;


	void Start (){
		if (canTimer==false){timerTextObj.SetActive(false);}
		else {
			timerTextObj.SetActive(true);
			UpdateTimer();
		}
	}

	void FixedUpdate(){
		   if (canTimer){
              theTimer += 0.01f;
              if (theTimer >= 1f){
                     timer -=1;
                     theTimer = 0;
                     UpdateTimer();
              }
		   }
			 if (timer <= 0){
				 LoseGame();
			 }
    }

      public void UpdateTimer(){
            Text timeTextTemp = timerText.GetComponent<Text>();
            timeTextTemp.text = "" + timer;
      }

		public void LoseGame(){
				SceneManager.LoadScene("LoseScreen");
		}

}
