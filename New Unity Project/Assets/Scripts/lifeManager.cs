using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if(health > 80f)
        {
        	player.GetComponent<SpriteRenderer>().sprite = character[0];
        }
        if(health > 60f && health < 80f)
        {
        	player.GetComponent<SpriteRenderer>().sprite = character[1];
        }
        if(health > 40f && health < 60f)
        {
        	player.GetComponent<SpriteRenderer>().sprite = character[2];
        }
        if(health > 20f && health < 40f)
        {
        	player.GetComponent<SpriteRenderer>().sprite = character[3];
        }
        if(health < 20f)
        {
        	player.GetComponent<SpriteRenderer>().sprite = character[4];
        }
    }

    public void GameOver(){

    	Debug.Log("U died!");
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //<--- Dying Mechanic

    }
}
