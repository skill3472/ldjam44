﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") == 1)
        {
        	Debug.Log("1");
        }
        if(Input.GetAxis("Horizontal") == -1)
        {
        	Debug.Log("-1");
        }
    }
}
