using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerManager : MonoBehaviour
{
	public float move;
	public Rigidbody2D rb;
	public bool isJumping;
	public lifeManager lm;
	public AudioSource jump;
	public GameObject endgame;
	public GameObject GM;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        GM = GameObject.Find("_GM");
        lm = GM.GetComponent<lifeManager>();
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

    void OnCollisionEnter2D(Collision2D col){

		isJumping = false;
		if(col.gameObject.tag == "Killer")
		{
			lm.GameOver();
		}
    }

    void OnTriggerEnter2D(Collider2D coll){

    	Debug.Log("Is on trigger...");
    	if(coll.gameObject.tag == "Finish")
    	{
    		Finish();
    	}
    	if(coll.gameObject.tag == "EndGame")
    	{
    		endgame.SetActive(true);
    	}

    }

    public void Finish(){
    	if(SceneManager.sceneCountInBuildSettings - 1 > SceneManager.GetActiveScene().buildIndex)
    	{
    		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    	}
    	Debug.Log("Level finished!");
    }
}
