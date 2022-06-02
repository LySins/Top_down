using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionOnObject : MonoBehaviour
{
    private GameObject _staff;
    private Color _MouseColor = Color.red;
    void Start()
    {
        _staff = GetComponent<GameObject>();     
    }
    void OnMouseOver()
    {
        Debug.Log("Is over");
        _MouseColor = Color.yellow;
    }
    void OnMouseExit()
    {
        Debug.Log("Is not over");
        _MouseColor = Color.red;
    }
    void Update()
    {
        
    }
}
