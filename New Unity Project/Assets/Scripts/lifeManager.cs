using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifeManager : MonoBehaviour
{

	public Slider healthSlider;
	public float health;
	public Text healthText;

    // Start is called before the first frame update
    void Start()
    {

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
    }

    void GameOver(){

    	Debug.Log("U died!");

    }
}
