using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonCtrl : MonoBehaviour
{

	public int progressIndex;
 
	public void OnQuitButton(){

		Application.Quit(); 

	}

	public void OnStartButton(){

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
