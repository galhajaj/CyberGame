﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour {

    public string name;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        Debug.Log("clicked Computer " + name);
    }
}
