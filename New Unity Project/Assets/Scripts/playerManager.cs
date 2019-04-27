using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
	public float move;
	public Rigidbody2D rb;
	public bool isJumping;
	public lifeManager lm;
	public AudioSource jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    	move = 10f;

    	if(Input.GetButton("Left"))
    	{
    		rb.velocity = new Vector2(-move, rb.velocity.y);
    	}
    	if(Input.GetButton("Right"))
    	{
    		rb.velocity = new Vector2(move, rb.velocity.y);
    	}
    	if(Input.GetButton("Right") == false && Input.GetButton("Left") == false)
    	{
    		rb.velocity = new Vector2(0, rb.velocity.y);
    	}
    	if(Input.GetButtonDown("Jump") && isJumping == false)
    	{
    		rb.velocity = new Vector2(rb.velocity.x, move);
    		isJumping = true;
    		lm.health -= 2f;
    		jump.Play();
    	}
    }

    void OnCollisionEnter2D(){

		isJumping = false;

    }
}
