using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRestart : MonoBehaviour {

    WaterVail _vail;
	// Use this for initialization
	void Start () {
<<<<<<< HEAD
        _vail = GameObject.Find("Vail").GetComponent<WaterVail>();
=======
        _vail = transform.parent.Find("Vail").GetComponent<WaterVail>();
>>>>>>> parent of 76010bb... added games to gamescene
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
