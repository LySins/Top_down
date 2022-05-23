using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleAttack : MonoBehaviour
{
    public Transform _attackPoint;
    public LayerMask _damageAbleLayerMask;
    public float _damageValue;
    public float _damageRadius;
    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {   
            //_animator.SetTrigger("PlayerMeleAttack");
            Debug.Log("Attack");
            PlayerMeleAttack();
        }
        
    }

  public void PlayerMeleAttack()
  {
      var enemies = Physics2D.OverlapCircleAll(-_attackPoint.position, _damageRadius, _damageAbleLayerMask);

      if (enemies.Length>0)
      {
          for(int i = 0; i < enemies.Length; i++)
          {
              enemies[i].GetComponent<EntityDamage>().TakeDamage(_damageValue);
          }
      }
  }
}
