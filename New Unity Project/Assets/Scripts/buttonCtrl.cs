using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonCtrl : MonoBehaviour
{

	public int progressIndex;
 
	void OnQuitButton(){

		Application.Quit(); 

	}

	void OnStartButton(){

		SceneManager.LoadScene(progressIndex);

	}

	void Start(){

		if(ES3.KeyExists("progress"))
		{
			progressIndex = ES3.Load<int>("progress");
		}
		else
		{
			progressIndex = 1;
		}
	}

}
