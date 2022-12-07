using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour
{

       public GameObject TextBox;
       public Text TextBox_text;
       public GameObject ButtonKeyTrigger;
       public BoxCollider2D bc2D;
       public Rigidbody2D rb2D;
       public string[] dialogue;
       public int counter = 0;
       public int dialogueLength;

	public bool isEvent = false;
	public bool doEvent = false;

       void Start(){
              TextBox.SetActive(false);
              ButtonKeyTrigger.SetActive(false);
              dialogueLength = dialogue.Length; //allows us test dialogue without an NPC
       }

       private void OnTriggerEnter2D(Collider2D other){
              //temporary testing before NPC is created
              if (other.gameObject.tag == "InteractiveComponent"){
                     ButtonKeyTrigger.SetActive(true);
              }
              if (Input.GetKeyDown("x")){
                     ButtonKeyTrigger.SetActive(false);
                     TextBox.SetActive(true);
                     TextBox_text.text = "It works!"; //reset text
                     counter = 0; //reset counter
              }
              if (Input.GetKeyDown("c")){
                TextBox.SetActive(false);
              }
       }

       public void OpenDialogue(){
              TextBox.SetActive(true);
       }

       public void CloseDialogue(){
              TextBox.SetActive(false);
              TextBox_text.text = "..."; //reset text
              counter = 0; //reset counter
       }

       public void LoadDialogueArray(string[] NPCscript, int scriptLength){
              dialogue = NPCscript;
              dialogueLength = scriptLength;
       }

        //function for the button to display next line of dialogue
       public void DialogueNext(){
              if (counter < dialogueLength){
                     TextBox_text.text = dialogue[counter];
                     counter +=1;
              }
              else { //when lines are complete:
                     TextBox.SetActive(false); //turn off the dialogue display
                     TextBox_text.text = "..."; //reset text
                     counter = 0; //reset counter
					 if (isEvent == true){
						 doEvent = true;
					 }
              }
       }

}
