﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEyes : MonoBehaviour {

    public bool _active;
    GameWater _manager;
    Sprite _sprite;

    const float TIME_TO_CHANGE_DIRECTION = 0.2f;

    bool _isMoving;
    float _timeToSwitch;
    // Use this for initialization
    void Start () {
        _manager = transform.parent.Find("GameWaterManager").GetComponent<GameWater>();
        _sprite = GetComponent<SpriteRenderer>().sprite;
        Init();
    }

    // Update is called once per frame
    void Update () {
        Move();
    }

    void OnMouseDown()
    {
        if (!_active)
            return;
        _isMoving = true;
        _manager.ObjectClicked("eyes");
        //        _manager.
    }

    public void Init()
    {
        _active = true;
        _isMoving = false;
        _timeToSwitch = TIME_TO_CHANGE_DIRECTION;
//        gameObject.SetActive(true);
    }

    void Move()
    {
        if (_isMoving)
        {
            _timeToSwitch -= Time.deltaTime;
            if (_timeToSwitch < 0)
            {
                _timeToSwitch = TIME_TO_CHANGE_DIRECTION;
                if(this.transform.rotation.z > 0)
                    this.transform.Rotate(0, 0, -10);
                else this.transform.Rotate(0, 0, 10);
            }
        }
    }

    public void StopMoving()
    {
        _isMoving = false;
        transform.Rotate(0, 0, 0);
    }

    public void Disable()
    {
//        gameObject.SetActive(false);
    }

    public void ObjectWasClicked(string newObject)
    {
        if (newObject == "vail" && _isMoving)
        {
            Disable();
        }

        StopMoving();
    }
}
