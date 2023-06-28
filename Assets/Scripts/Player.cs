using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D body;
    public BoxCollider2D collision;
    public TrailRenderer trail;
    private void Awake() {
        body = GetComponent<Rigidbody2D>();
        collision = GetComponent<BoxCollider2D>();
        trail = gameObject.GetComponent<TrailRenderer>();
    }    bool jump = true;

    // Update is called once per frame
    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalinput * 5,body.velocity.y);
        if(Input.GetKey(KeyCode.Space))
        {
            if(jump == true){
                body.velocity = new Vector2(body.velocity.x,5);
                jump = false;
            }
        }
        if(Input.GetKey(KeyCode.W))
        {
            if(jump == true){
                body.velocity = new Vector2(body.velocity.x,5);
                jump = false;
            }
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            if(jump == true){
                body.velocity = new Vector2(body.velocity.x,5);
                jump = false;
            }
        }       
    }
    private void OnMouseDown() {
        body.velocity = new Vector2(body.velocity.x,5);
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        jump = true;
        if (collision.gameObject.tag == "Death"){
            body.position = new Vector2(0,0);
        }
        if (collision.gameObject.tag == "Jump Pad"){
            body.velocity = new Vector2(body.velocity.x,25);
        }
    }
}
