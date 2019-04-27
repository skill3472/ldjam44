using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonCtrl : MonoBehaviour
{
 
	void OnQuitButton(){

		Application.Quit();

	}

	void OnStartButton(){

		SceneManager.LoadScene("LVL1");

	}

}
