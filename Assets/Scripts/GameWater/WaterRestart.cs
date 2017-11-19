using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRestart : MonoBehaviour {

    WaterVail _vail;
	// Use this for initialization
	void Start () {
        _vail = GameObject.Find("Vail").GetComponent<WaterVail>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if (_vail.IsSuccess())
        {
            Debug.Log("SUCCESS");
        }
        else
        {
            GameObject.Find("GameWaterManager").GetComponent<GameWater>().RestartScene();    
        }
    }
}
