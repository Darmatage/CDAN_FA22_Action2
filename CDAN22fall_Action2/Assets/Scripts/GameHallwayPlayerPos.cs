using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHallwayPlayerPos : MonoBehaviour{
	
	public Transform player;
	
	public Transform hallwayPos1;
	public Transform hallwayPos2;
	public Transform hallwayPos3;
	
	// public Vector3 hallwayPos1 = new Vector3 (-17.5f, -6f, 0);
	// public Vector3 hallwayPos2 = new Vector3 (-17.5f, 2.5f, 0);
	// public Vector3 hallwayPos3 = new Vector3 (5.6f, 4.4f, 0);
	
    void Awake(){
        player = GameObject.FindWithTag("Player").transform;
			Debug.Log("The recentRoom value is " + GameTracking.recentRoom);
		
		//player.position = hallwayPos3.position;
		
		//if (GameTracking.isHallway==true){
			if (GameTracking.recentRoom == "room1"){
				player.position = hallwayPos1.position;
				Debug.Log("I put the player in p1");
			}
			else if (GameTracking.recentRoom == "room2"){
				player.position = hallwayPos2.position;
				Debug.Log("I put the player in p2");
			}
			else if (GameTracking.recentRoom == "room3"){
				player.position = hallwayPos3.position;
				Debug.Log("I put the player in p3");
			}				
		//}
    }

	
	
}
