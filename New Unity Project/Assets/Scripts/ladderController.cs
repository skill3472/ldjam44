using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladderController : MonoBehaviour
{

	public GameObject endpoint;

    // Start is called before the first frame update
    void Start()
    {
        endpoint = gameObject.transform.GetChild(0).gameObject;
    }



    void OnTriggerStay2D(Collider2D col){

    	if(col.gameObject.tag == "Player" && Input.GetButtonDown("Use"))
    	{
    		col.gameObject.transform.position = endpoint.transform.position;
    	}

    }
}
