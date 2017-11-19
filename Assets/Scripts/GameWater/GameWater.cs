using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWater : MonoBehaviour {


    string _clickedObject;

    //public Sprite 

    WaterFrog _frog;
    WaterEyes _eyes;
    WaterVail _vail;
    WaterGlass _glass20;
    WaterGlass _glass50;
    WaterBanana _banana = GameObject.Find("Banana").GetComponent<WaterBanana>();

    bool _is20GlassFull;
    bool _is50GlassFull;

	// Use this for initialization
	void Start () {
        _frog = GameObject.Find("Frog").GetComponent<WaterFrog>();
        _eyes = GameObject.Find("Eye").GetComponent<WaterEyes>();
        _vail = GameObject.Find("Vail").GetComponent<WaterVail>();
        _glass20 = GameObject.Find("Glass20").GetComponent<WaterGlass>();
        _glass50 = GameObject.Find("Glass50").GetComponent<WaterGlass>();
        _banana = GameObject.Find("Banana").GetComponent<WaterBanana>();

        _glass20.SetOtherGlass(ref _glass50);
        _glass50.SetOtherGlass(ref _glass20);

        RestartScene();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RestartScene()
    {
        _clickedObject = "none";

        _banana.Init();
        _frog.Init();
        _vail.Init();
        _glass20.Init();
        _glass50.Init();

    }

    public void ObjectClicked(string objectName)
    {        
        _clickedObject = objectName;
        if (objectName != "frog")
            _frog.ObjectWasClicked(objectName);
        if (objectName != "eyes")
            _eyes.ObjectWasClicked(objectName);
//        _vail.ObjectWasClicked(objectName);
        if (objectName != "glass20")
            _glass20.ObjectWasClicked(objectName);
        if (objectName != "glass50")
            _glass50.ObjectWasClicked(objectName);

    }

    public string GetPreviewsObject()
    {
        Debug.Log(_clickedObject);
        return _clickedObject;
    }

}
