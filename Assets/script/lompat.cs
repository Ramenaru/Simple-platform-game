using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lompat : MonoBehaviour{
 
    public float jump;
    bool berpijak = true;
    public bool Floor;
    public Transform Detection;
    public LayerMask Layer_Sellection;
    public float Radius;

    void Update(){

        Floor = Physics2D.OverlapCircle(Detection.position, Radius, Layer_Sellection);
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && Floor){
            if(berpijak){
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);

            }
        }
    }
}
