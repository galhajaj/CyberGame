using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullArrowPressed : MonoBehaviour {
    public bool IsUp;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        Debug.Log("clicked");
        ((Digit)transform.parent.GetComponentInChildren<Digit>()).ChangeDigit(IsUp);
    }
}
