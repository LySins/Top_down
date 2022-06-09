using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneral : MonoBehaviour
{
    public float _enemySpeed;
    public float _agroRange;
    public float _stopEnemyPoint;
    public float _GiveEnemyDamage = 10.0f;
    public Transform  _playerPosition;
    public Vector2 _enemyDirection;
    private Rigidbody2D _enemyRigbody;
    void Start()
    {
        _enemyRigbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixUpdate()
    {
        float _rangePlayer = Vector2.Distance(transform.position, _playerPosition.position);
        if (_rangePlayer < _agroRange)
        {
            StartHunting();
        }
        else
        {
            StopHunting();
        }
    }

    void StartHunting()
    {
        if (_playerPosition.position.x < transform.position.x)
        {
            _enemyRigbody.velocity = new Vector2(-_enemySpeed, 0);
            transform.localScale = new Vector2(1, 1);
        }
        else if(_playerPosition.position.x > transform.position.x)
        {
            _enemyRigbody.velocity = new Vector2(_enemySpeed, 0);
            transform.localScale = new Vector2(-1, 1);
        }
        
    }
    void StopHunting()
    {
        _enemyRigbody.velocity = new Vector2(0,0);
    }
}
