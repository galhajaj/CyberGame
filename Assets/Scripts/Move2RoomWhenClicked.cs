using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2RoomWhenClicked : MonoBehaviour
{
    public string RoomName;

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    private void OnMouseDown()
    {
        CameraManager.Instance.MoveToRoom(RoomName);
    }
}
