using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    GameObject _camera;
    Transform _player;

    void Start()
    {
        _camera = GetComponent<GameObject>();
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        
    }
}
