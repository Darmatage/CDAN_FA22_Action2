using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoCollider : MonoBehaviour
{

  public GameObject pressPText;


    // Start is called before the first frame update
    void Start()
    {
        pressPText.SetActive(false);
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="Player"){
          pressPText.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag=="Player"){
          pressPText.SetActive(false);
        }
    }


}
