using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool InPlay;
    public Transform paddlePos;
    private float ballSpeed=500;

    private void Start() {
        rb=GetComponent<Rigidbody2D>();
        
    }

    private void Update() {
        if(!InPlay){
            transform.position=paddlePos.position;
        }
        if(Input.GetKey(KeyCode.E)&& !InPlay){
            InPlay=true;
            rb.AddForce(Vector2.up*ballSpeed);

        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Bottom")){
            //Debug.Log("Ball Hit the Bottom Of screen");
            rb.velocity=Vector2.zero;
            InPlay=false;
        }
    }

    
}
