using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

	private int sceneIndexNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
        	sceneIndexNumber = SceneManager.GetActiveScene().buildIndex;
        	ES3.Save<int>("progress", sceneIndexNumber);
        	SceneManager.LoadScene(0);
        }
    }
}
