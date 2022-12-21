 using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BGSoundScript : MonoBehaviour {

    private static BGSoundScript instance = null;
	public bool stopOldMusic = false;

	public static BGSoundScript Instance{
                get {return instance;}
	}

	void Awake(){
		if (stopOldMusic == false){
                if (instance != null && instance != this){
                        Destroy(this.gameObject);
                        return;
                } else {
                        instance = this;
                }
                DontDestroyOnLoad(this.gameObject);
		}
	}
	
	void Start(){
		if (stopOldMusic == true){
			StopOldMusic();
		}
	}
		
	public void StopOldMusic() {
                BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
		
} 