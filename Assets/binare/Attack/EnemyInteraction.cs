using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteraction : MonoBehaviour
{   
    [SerializeField]
    public int _enemyHealth = 100;
    public int _enemyDamage = 10;
    public float _waitAttackTime = 2.0f;
    public int _ratingScore = 10;
    public GameObject _otherPlayer;

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
             other.GetComponent<PlayerInteraction>().TakeDamage(_enemyDamage, _waitAttackTime);
        }
        
    }

    public void TakeDamageEnemy(int _damage)
    {
        _enemyHealth-=_damage;
        if (_enemyHealth <= 0)
        {
            EnemyDead();
        }
    }

    private void EnemyDead()
    {   
        //_otherPlayer = GameObject.Find("Player");
        _otherPlayer.GetComponent<PlayerInteraction>().ScoreCounter(_ratingScore);
        Destroy(gameObject);
    }
}
