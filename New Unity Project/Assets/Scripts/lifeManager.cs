using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifeManager : MonoBehaviour
{

	public Slider healthSlider;
	public float health;
	public Text healthText;
	public List<Sprite> character;
	public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
    	player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
    	health -= Time.deltaTime;
        healthSlider.value = health;
        healthText.text = Mathf.Round(health).ToString();

        if(health <= 0f)
        {
        	GameOver();
        }
        if(health > 50f)
        {
        	player.GetComponent<SpriteRenderer>().sprite = character[0];
        }
        if(health > 40f && health < 50)
        {
        	player.GetComponent<SpriteRenderer>().sprite = character[1];
        }
        if(health > 30f && health < 40)
        {
        	player.GetComponent<SpriteRenderer>().sprite = character[2];
        }
        if(health > 20f && health < 30)
        {
        	player.GetComponent<SpriteRenderer>().sprite = character[3];
        }
        if(health > 10f && health < 20)
        {
        	player.GetComponent<SpriteRenderer>().sprite = character[4];
        }
        if(health < 10f)
        {
        	player.GetComponent<SpriteRenderer>().sprite = character[5];
        }
    }

    public void GameOver(){

    	Debug.Log("U died!");

    }
}
