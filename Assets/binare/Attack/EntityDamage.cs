using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityDamage : MonoBehaviour
{
    public float _healthPoints;

    public void TakeDamage(float damage)
    {
        _healthPoints-=damage;
        if (_healthPoints<=0)
        {
            EntityDead();
        }
    }

    public void EntityDead()
    {
        Destroy(gameObject);
    }
}
