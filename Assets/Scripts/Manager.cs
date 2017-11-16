using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    void Awake()
    {
        Physics2D.queriesHitTriggers = true; //needed so the objects will get notification where the mouse clicks on them
    }

	void Start ()
    {
        Debug.Log("Startttttt");
	}
	
	void Update ()
    {
        // TODO: move to main scene
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
	}
}
