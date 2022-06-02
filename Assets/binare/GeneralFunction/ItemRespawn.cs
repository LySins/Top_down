using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRespawn : MonoBehaviour
{
    public GameObject _item;
    public Transform _itemSpawnPosition;

    public float _ItemCD = 1.0f;
    private Vector3 _spawnItemPosiiton;

    void Start()
    {
        RespawnItem();
    }

    void Update()
    {

    }
    void RespawnItem()
    {
        StartCoroutine(SpawnItemCD());
    }
    IEnumerator SpawnItemCD()
    {
        _spawnItemPosiiton = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0);
        yield return new WaitForSeconds(_ItemCD);
        Instantiate(_item, _spawnItemPosiiton, Quaternion.identity);
        RespawnItem();
    }
}
