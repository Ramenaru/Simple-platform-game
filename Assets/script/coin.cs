using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour{
    
    void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.tag.Equals ("Karakter")){
            print("coin diambil");
            Destroy (gameObject);
            coinscore.hitungCoin += 50;
        }
    }
}
