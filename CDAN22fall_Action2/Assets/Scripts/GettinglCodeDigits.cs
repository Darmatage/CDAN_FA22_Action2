using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingCodeDigits : MonoBehaviour
{

  public GameObject codeNumber1;
  public GameObject codeNumber2;
  public GameObject codeNumber3;
  public GameObject codeNumber4;

    // Start is called before the first frame update
    void Start(){
        codeNumber1.SetActive(false);
        codeNumber2.SetActive(false);
        codeNumber3.SetActive(false);
        codeNumber4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
