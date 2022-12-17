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
      public GameHandler gameHandler;


	public Vector3 hallwayPos1 = new Vector3 (-17.5f, -6f, 0);
	public Vector3 hallwayPos2 = new Vector3 (-17.5f, 2.5f, 0);
	public Vector3 hallwayPos3 = new Vector3 (5.6f, 4.4f, 0);


	void Start(){
		anim = gameObject.GetComponentInChildren<Animator>();
		rb2D = transform.GetComponent<Rigidbody2D>();

		// HALLWAY POSITIONS: GET THIS WORKING
		
		// if (GameTracking.isHallway==true){
			// if (GameTracking.recentRoom=="room1"){
				// transform.position = hallwayPos1;
			// }
			// else if (GameTracking.recentRoom=="room2"){
				// transform.position = hallwayPos2;
			// }
			// else if (GameTracking.recentRoom=="room3"){
				// transform.position = hallwayPos3;
			// }				
		// }

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
