using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class BGSoundScript : MonoBehaviour {

    private static BGSoundScript instance = null;
	public bool stopOldMusic = false;

	public AudioSource mainMenu;
	public AudioSource Room1;
	public AudioSource Room2;
	public AudioSource Room3;	
	public AudioSource Room5;
	public AudioSource Shop;

	private string sceneName;
	public string currentSong;

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
	
	void Update(){
		
		sceneName = SceneManager.GetActiveScene().name;
		if ((sceneName == "MainMenu") || 
			(sceneName == "Credits") || 
			(sceneName == "Controls") ||
			(sceneName == "WinScreen") || 
			(sceneName == "LoseScreen") || 
			(sceneName == "TopFloorHallway") || 
			(sceneName == "BottomFloorHallway") || 
			(sceneName == "OpeningCutScene")){
			if (!mainMenu.isPlaying){ 
				mainMenu.Play();
			}
			Room1.Stop();
			Room2.Stop();
			Room3.Stop();	
			Room5.Stop();
			Shop.Stop();
			currentSong = "MainMenu";
		} else if (sceneName == "Level1Bedroom_new"){
			mainMenu.Stop();
			if (!Room1.isPlaying){
				Room1.Play();
			}
			Room2.Stop();
			Room3.Stop();	
			Room5.Stop();
			Shop.Stop();
			currentSong = "Level1";
		} else if (sceneName == "Level2Bathroom"){
			mainMenu.Stop();
			Room1.Stop();
			if (!Room2.isPlaying){
				Room2.Play();
			}
			Room3.Stop();
			Room5.Stop();
			Shop.Stop();
			currentSong = "Level2";
		}else if (sceneName == "Level3SiblingBedroom"){
			mainMenu.Stop();
			Room1.Stop();
			Room2.Stop();
			if (!Room3.isPlaying){
				Room3.Play();
			}
			Room5.Stop();
			Shop.Stop();
			currentSong = "Level3";
		} else if (sceneName == "Level5LivingRoom"){
			mainMenu.Stop();
			Room1.Stop();
			Room2.Stop();
			Room3.Stop();
			if (!Room5.isPlaying){			
				Room5.Play();
			}
			Shop.Stop();
			currentSong = "Level5";
		} else if (sceneName == "HallwayShop"){
			mainMenu.Stop();
			Room1.Stop();
			Room2.Stop();
			Room3.Stop();	
			Room5.Stop();
			if (!Shop.isPlaying){
				Shop.Play();
			}
			currentSong = "Shop";
		}
		
		//if (){
		//	StopOldMusic();
		//}
		
	}
	
	
	public void StopOldMusic() {
                BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
		
} 