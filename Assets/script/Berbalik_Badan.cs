using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berbalik_Badan : MonoBehaviour {

    GameObject karakter;
    bool p=true;
    // Start is called before the first frame update
    void Start(){
        karakter = GameObject.Find("Karakter");
    }

    // Update is called once per frame
    void Update(){
        //berbalik ke kiri
        if (karakter.transform.eulerAngles.y == 0){
            if (Input.GetKey(KeyCode.LeftArrow)){
                transform.Rotate(0, 180, 0);
               
            }
        }
        //berbalik ke kanan
        else if (karakter.transform.eulerAngles.y == 180){
            if (Input.GetKey(KeyCode.RightArrow)){
                transform.Rotate(0, -180, 0);
                
            }
        }
    }
}
