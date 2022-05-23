using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteract : MonoBehaviour
{
    bool _checkerColliderActive = false;
    public int _itemNominalHeal = 10;
    GameObject player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _checkerColliderActive = true;
        }
    }

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        
    }
    void Update()
    {
        if (_checkerColliderActive == true)
        {
            player.GetComponent<PlayerInteraction>().HealingPlayer(_itemNominalHeal);
            Destroy(gameObject);
        }
    }
}
