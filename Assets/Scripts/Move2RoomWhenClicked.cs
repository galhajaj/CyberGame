using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2RoomWhenClicked : MonoBehaviour
{
    public string RoomName;
    public bool IsImmediate = false;

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    private void OnMouseDown()
    {
        if (!IsImmediate)
            CameraManager.Instance.MoveToRoom(RoomName);
        else
            CameraManager.Instance.MoveToRoomImmediately(RoomName);
    }
}
