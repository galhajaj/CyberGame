using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGlass : MonoBehaviour {

    public int GlassSize;
    public Sprite EmptyGlass;
    public Sprite FullGlass;
    public Sprite HalfFullGlass;

    SpriteRenderer _sprite;
    WaterGlass _otherGlass;

    const float TIME_TO_CHANGE_DIRECTION = 0.2f;

    GameWater _manager;

    bool _isMoving;
    float _timeToSwitch;

    int _cc; //0=empty; 1=half 2=full


    public int GetWater()
    {
        return _cc;
    }
    public void SetOtherGlass(ref WaterGlass other)
    {
        _otherGlass = other;        
    }

    // Use this for initialization
	void Start () {
        _sprite = GetComponent<SpriteRenderer>();
        _manager = GameObject.Find("GameWaterManager").GetComponent<GameWater>();
        Init();
	}
	
	// Update is called once per frame
	void Update () {
        Move();	
	}
    void SetSprite()
    {
        if (_cc == 0)
        {
            _sprite.sprite = EmptyGlass;
        }
        else if (_cc == GlassSize)
        {
            _sprite.sprite = FullGlass;
        }
        else
        {
            _sprite.sprite = HalfFullGlass;
        }
    }

    public void Fill(int cc)
    {
        _cc += cc;
        if (_cc > GlassSize)
        {
            _cc = GlassSize;
        }

        SetSprite();
    }

    public void Init()
    {
        _isMoving = false;
        _timeToSwitch = TIME_TO_CHANGE_DIRECTION;
        _cc = 0;
        SetSprite();
        transform.Rotate(0, 0, 0);

    }

    public void Empty()
    {
        _cc = 0;
        SetSprite();
    }

    void OnMouseDown()
    {
        string name = "glass" + GlassSize.ToString();

        if(!_otherGlass._isMoving)
            _isMoving = true;
        _manager.ObjectClicked(name);
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

    void StopMoving()
    {
        _isMoving = false;
        transform.rotation.Set(0, 0, 0, 0);
    }
        
    public void ObjectWasClicked(string newObject)
    {
        if (!_isMoving)
            return;
        if (newObject == "tap")
        {
            Fill(GlassSize);
        }

        if (newObject == "glass20" || newObject == "glass50")
        {
            int ccToMove = _otherGlass.GlassSize - _otherGlass._cc;
            if(_cc < ccToMove)
            {
                ccToMove = _cc;
            }

            _cc -= ccToMove;
            _otherGlass.Fill(ccToMove);
            SetSprite();
        }

        StopMoving();
    }
}
