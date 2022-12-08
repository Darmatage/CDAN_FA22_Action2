using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerMoveAround : MonoBehaviour {

      public Animator anim;
      //public AudioSource WalkSFX;
      public Rigidbody2D rb2D;
      private bool FaceRight = false; // determine which way player is facing.
      public static float runSpeed = 7f;
      public float startSpeed = 7f;
      public bool isAlive = true;

	void Start(){
		anim = gameObject.GetComponentInChildren<Animator>();
		rb2D = transform.GetComponent<Rigidbody2D>();

		// room 1
		if (GameTracking.isRoom1==true){
			transform.position = new Vector2(-28.4f, -23.5f);
		}
		// hallway
		//previous error: was looking at non-static variable and only had one =
		if ((GameTracking.isHallway==true)&&(GameTracking.escapedRoom1==true)){
			//what are you trying to do here-- are you trying to put thr player in a location??
			//((Input.GetAxis("Horizontal") != -29.8) || (Input.GetAxis("Vertical") != -32.8));
			transform.position = new Vector2 (-29.8f, -32.8f);
		}
      
		// room 3
		if (GameTracking.isRoom3==true){
			transform.position = new Vector2 (37.1f,-2.9f);
		}
	}

	void Update(){
		//NOTE: Horizontal axis: [a] / left arrow is -1, [d] / right arrow is 1
		//NOTE: Vertical axis: [w] / up arrow, [s] / down arrow
		Vector3 hvMove = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
		if (isAlive == true){
			transform.position = transform.position + hvMove * runSpeed * Time.deltaTime;

			if ((Input.GetAxis("Horizontal") != 0) || (Input.GetAxis("Vertical") != 0)){
			     anim.SetBool ("Walk", true);
			//     if (!WalkSFX.isPlaying){
			//           WalkSFX.Play();
			//     }
			} else {
			     anim.SetBool ("Walk", false);
			//     WalkSFX.Stop();
			}

			// Turning. Reverse if input is moving the Player right and Player faces left.
			if ((hvMove.x <0 && !FaceRight) || (hvMove.x >0 && FaceRight)){
				playerTurn();
			}
		}
	}

	private void playerTurn(){
		// NOTE: Switch player facing label
		FaceRight = !FaceRight;

		// NOTE: Multiply player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	  
}
