﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTap : MonoBehaviour {

    const float TIME_TO_POUR = 2;

    public Sprite TAP_CLOSED;
    public Sprite TAP_OPEN;

    SpriteRenderer _sprite;
    GameWater _manager;

    bool _isPourWater;
    float _timeToPour;
	// Use this for initialization
	void Start () {
        _sprite = GetComponent<SpriteRenderer>();
        _manager = GameObject.Find("GameWaterManager").GetComponent<GameWater>();
        Init();
    }
	
	// Update is called once per frame
	void Update () {
        if (_isPourWater)
        {
            _timeToPour -= Time.deltaTime;
        
            if (_timeToPour < 0)
            {
                _sprite.sprite = TAP_CLOSED;
                _isPourWater = false;
                _timeToPour = TIME_TO_POUR;
            }
        }
	}


    public void Init()
    {
        _isPourWater = false;
        _timeToPour = TIME_TO_POUR;
        gameObject.SetActive(true);
        _sprite.sprite = TAP_CLOSED;
    }

    void OnMouseDown()
    {
        _isPourWater = true;
        _sprite.sprite = TAP_OPEN;
        _manager.ObjectClicked("tap");

    }

    public void ObjectWasClicked(string newObject)
    {
    }
}
