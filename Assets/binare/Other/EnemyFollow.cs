using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    GameObject player;
    public float _speedMove = 3.0f;
    public float _agroRange = 5.0f;
    protected float _directionY;
    protected float _directionX;
    protected Vector3 _position; 

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        _position.Normalize();

    }
    
 
    void LateUpdate()
    {
        _directionX = player.transform.position.x - transform.position.x;
        _directionY = player.transform.position.y - transform.position.y;
 
        if ((Mathf.Abs(_directionX) < _agroRange) && (Mathf.Abs(_directionY) < _agroRange))
        {
            _position = transform.position;
            _position.x += Mathf.Sign(_directionX) * _speedMove * Time.deltaTime;
            _position.y += Mathf.Sign(_directionY) * _speedMove * Time.deltaTime;
            transform.position = _position;
        }
        else if(player.transform.position == transform.position)
        {
            _speedMove = 0.0f;
        }
    }
}
