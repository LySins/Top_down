using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombFireInteractive : MonoBehaviour
{
    private bool _LogicOfEnteringColl = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            _LogicOfEnteringColl = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            _LogicOfEnteringColl = false;
        }
    }

    void Update()
    {
        if((Input.GetKeyDown(KeyCode.E) == true) && (_LogicOfEnteringColl == true))
        {
            Debug.Log("FireOfRise is active");
        }
    }
}
