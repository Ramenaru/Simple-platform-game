using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter : MonoBehaviour{
    
    public float speed;
    Rigidbody2D aff;


    void Start(){
        aff = GetComponent<Rigidbody2D>();
    }

    
    void Update(){
        
    }

    void FixedUpdate(){
        float move = Input.GetAxis("Horizontal");
        aff.velocity = new Vector2 (speed*move, aff.velocity.y);
    }
}
