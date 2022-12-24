using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorPuzzle_System : MonoBehaviour{
    
	private bool solvedIt = false;
	private bool solveSwitch = true;
	
	public Transform object1;
	public Transform object2;
	public Transform object3;
	public Transform object4;

	public GameObject reflection1;
	public GameObject reflection2;
	public GameObject reflection3;
	public GameObject reflection4;
	
	public float buff = 0.3f;
	public GameObject toilet;
	public GameObject lootDrop;
	public AudioSource flush;
	
	//set private when works
	public float reflect1PosX;
	public float reflect2PosX;
	public float reflect3PosX;
	public float reflect4PosX;
	
	public float obj1PosX;
	public float obj2PosX;
	public float obj3PosX;
	public float obj4PosX;
	

    void Start(){
        reflect1PosX = reflection1.transform.position.x;
		reflect2PosX = reflection2.transform.position.x;
		reflect3PosX = reflection3.transform.position.x;
		reflect4PosX = reflection4.transform.position.x;
    }

    void Update(){
        obj1PosX = object1.position.x;
		obj2PosX = object2.position.x;
		obj3PosX = object3.position.x;
		obj4PosX = object4.position.x;
		
		if (((reflect1PosX + buff) >= obj1PosX && obj1PosX >= (reflect1PosX - buff)) ||
			((reflect1PosX + buff) >= obj2PosX && obj2PosX >= (reflect1PosX - buff)) ||
			((reflect1PosX + buff) >= obj3PosX && obj3PosX >= (reflect1PosX - buff)) ||
			((reflect1PosX + buff) >= obj4PosX && obj4PosX >= (reflect1PosX - buff))){
			reflection1.SetActive(true);	
		} else {reflection1.SetActive(false);}
		
		if (((reflect2PosX + buff) >= obj1PosX && obj1PosX >= (reflect2PosX - buff)) ||
			((reflect2PosX + buff) >= obj2PosX && obj2PosX >= (reflect2PosX - buff)) ||
			((reflect2PosX + buff) >= obj3PosX && obj3PosX >= (reflect2PosX - buff)) ||
			((reflect2PosX + buff) >= obj4PosX && obj4PosX >= (reflect2PosX - buff))){
			reflection2.SetActive(true);	
		} else {reflection2.SetActive(false);}
		
		if (((reflect3PosX + buff) >= obj1PosX && obj1PosX >= (reflect3PosX - buff)) ||
			((reflect3PosX + buff) >= obj2PosX && obj2PosX >= (reflect3PosX - buff)) ||
			((reflect3PosX + buff) >= obj3PosX && obj3PosX >= (reflect3PosX - buff)) ||
			((reflect3PosX + buff) >= obj4PosX && obj4PosX >= (reflect3PosX - buff))){
			reflection3.SetActive(true);	
		} else {reflection3.SetActive(false);}
		
		if (( (reflect4PosX + buff) >= obj1PosX && obj1PosX >= (reflect4PosX - buff)) ||
			( (reflect4PosX + buff) >= obj2PosX && obj2PosX >= (reflect4PosX - buff)) ||
			( (reflect4PosX + buff) >= obj3PosX && obj3PosX >= (reflect4PosX - buff)) ||
			( (reflect4PosX + buff) >= obj4PosX && obj4PosX >= (reflect4PosX - buff))){
			reflection4.SetActive(true);	
		} else {reflection4.SetActive(false);}
		
		
		//solving
		if (( obj1PosX <= (reflect1PosX + buff) && obj1PosX >= (reflect1PosX - buff)) &&
			( obj2PosX <= (reflect2PosX + buff) && obj2PosX >= (reflect2PosX - buff)) &&
			( obj3PosX <= (reflect3PosX + buff) && obj3PosX >= (reflect3PosX - buff)) &&
			( obj4PosX <= (reflect4PosX + buff) && obj4PosX >= (reflect4PosX - buff)))
			 {solvedIt = true;} 
		else {solvedIt = false;}
		
		
		if ((solvedIt)&&(solveSwitch)){
			solveSwitch = false;
			SolvedPuzzle();
		}
		
    }
	
	public void SolvedPuzzle(){
		toilet.GetComponent<CircleCollider2D>().enabled = false;
		flush.Play();
		Instantiate (lootDrop, toilet.transform.position, Quaternion.identity);
	}

}
