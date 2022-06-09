using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    public GameObject _enemy;
    public Transform _enemySpawnPosition;
    public Transform[] _1enemySpawnPosition;

    public float _EnemyCD = 1.0f;
    private Vector3 _spawnEnemyPosiiton;

    void Start()
    {
        RespawnEnemy();
    }

    void RespawnEnemy ()
    {
        StartCoroutine(SpawnEnemyCD());
    }
    IEnumerator SpawnEnemyCD()
    {
        _spawnEnemyPosiiton = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0);
        yield return new WaitForSeconds(_EnemyCD);
        Instantiate(_enemy, _spawnEnemyPosiiton, Quaternion.identity);
        RespawnEnemy();
    }
}
