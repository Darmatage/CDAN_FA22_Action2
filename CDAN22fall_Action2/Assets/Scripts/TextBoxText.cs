using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxText : MonoBehaviour
{
  private TextBoxManager textMNGR;
      public string[] dialogue; //enter dialogue lines into the inspector for each NPC
      public bool playerInRange = false; //could be used to display an image: hit [e] to talk
      public int dialogueLength;

      void Start(){
             //anim = gameObject.GetComponentInChildren<Animator>();
             dialogueLength = dialogue.Length;
             if (GameObject.FindWithTag("ButtonTriggerManager")!= null){
                    textMNGR = GameObject.FindWithTag("ButtonTriggerManager").GetComponent<TextBoxManager>();
             }
      }

      private void OnTriggerEnter2D(Collider2D other){
             if (other.gameObject.tag == "Player") {
                    playerInRange = true;
                    textMNGR.LoadDialogueArray(dialogue, dialogueLength);
                    textMNGR.OpenDialogue();
                    //anim.SetBool("Chat", true);
                    //Debug.Log("Player in range");
             }
      }

      private void OnTriggerExit2D(Collider2D other){
             if (other.gameObject.tag =="Player") {
                    playerInRange = false;
                    textMNGR.CloseDialogue();
                    //anim.SetBool("Chat", false);
                    //Debug.Log("Player left range");
             }
      }
}
