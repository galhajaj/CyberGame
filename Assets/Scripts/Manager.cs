using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

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
