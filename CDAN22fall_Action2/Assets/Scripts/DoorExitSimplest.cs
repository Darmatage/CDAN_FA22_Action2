using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorExitSimplest : MonoBehaviour{

    public string NextLevel;

    public void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "Player"){
            SceneManager.LoadScene(NextLevel);
        }
    }

}
