using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullSend : MonoBehaviour {

    public Sprite SpriteLock;
    public Sprite SpriteUnlock;

    // Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().sprite = SpriteLock;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        bool isOpen = transform.parent.GetComponent<BullCodePlate>().TryToOpenLock();
        if (isOpen)
        {
            GetComponent<SpriteRenderer>().sprite = SpriteUnlock;
        }
    }
}
