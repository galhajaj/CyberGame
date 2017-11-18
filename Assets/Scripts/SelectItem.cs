using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectItem : MonoBehaviour
{

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public void SelectMe()
    {
        Debug.Log(this.tag + " item selected");
        this.GetComponent<Image>().color = Color.red;
        ItemsManager.Instance.CurrentItem = this.tag;
    }
}
