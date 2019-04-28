using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonCtrl : MonoBehaviour
{

	public int progressIndex;
	public GameObject credits;
 
	public void OnQuitButton(){

		Application.Quit(); 

	}

	public void OnStartButton(){

		SceneManager.LoadScene(progressIndex);

	}

	public void OnBackButton(){

		credits.SetActive(false);

	}

	public void OnCreditsButton(){

		credits.SetActive(true);

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
