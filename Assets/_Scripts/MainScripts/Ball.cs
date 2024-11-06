using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool InPlay;
    public Transform paddlePos;
    private float ballSpeed=500;
    public Transform effect;
    public GameManager gm;

    private void Start() {
        rb=GetComponent<Rigidbody2D>();
        
    }

    private void Update() {
        if(gm.gameOver){
            return;
        }
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
            gm.UpdateLives(-1);
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.transform.CompareTag("Brick")){
            Transform newEffect = Instantiate(effect, other.transform.position, other.transform.rotation);
            Destroy(newEffect.gameObject,2f);
            gm.UpdateScore(other.gameObject.GetComponent<BrickScript>().points);
            gm.UpdateNumberOfBricks();
            Destroy(other.gameObject);
        }
    }
}
