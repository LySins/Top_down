using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    public int _healthPlayer = 100;
    public int _damagePlayer = 10;
    public int _scorePlayer = 0;
    private bool _idicateActiveFire = false;
    CapsuleCollider2D _playerCapsulColider2d;

    void Update()
    {
        PlayerAttack();
    }
    public void TakeDamage(int _takeDamage, float _waitTime)
    {
       // StartCoroutine(CorutineTakeDamage(_waitTime));
        _healthPlayer-= _takeDamage;
        if(_healthPlayer <= 0)
            PlayerDead();
        
    }
    void Start()
    {
        _scorePlayer = 0;
        _playerCapsulColider2d  = GetComponent<CapsuleCollider2D>();
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if((other.tag == "Enemy")&&(_idicateActiveFire == true))
        {
             other.GetComponent<EnemyInteraction>().TakeDamageEnemy(_damagePlayer);
        }
        
    }

    public void PlayerDead()
    {
        _scorePlayer = 0;
        SceneManager.LoadScene("DeathMenu");
    }
    public void HealingPlayer(int _nominalHeal)
    {
        _healthPlayer+=_nominalHeal;
    }

    public void PlayerAttack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _idicateActiveFire = true;
        }
        else
        {
            _idicateActiveFire = false;

        }
    }
    public IEnumerator CorutineTakeDamage (float _waitTime)
    {
        yield return new WaitForSeconds(_waitTime);
    }
    
    public void ScoreCounter(int _ratingScore)
    {   
        _scorePlayer+=_ratingScore;
    }
}
