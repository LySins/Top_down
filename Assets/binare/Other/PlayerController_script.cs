using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_script : MonoBehaviour
{
    public float _speed = 20;
    private Vector2 _directon;
    private Vector3 mouse;
    public Rigidbody2D _rigidbody;
    public bool _facingRight = true;
        void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _speed=5f;       
    }

    // Update is called once per frame
    void Update()
    {
        _directon.x = Input.GetAxisRaw("Horizontal");
        _directon.y = Input.GetAxisRaw("Vertical");
    
    }
    
    void FixedUpdate()
    {   
        _directon.Normalize();
        _rigidbody.MovePosition(_rigidbody.position + _directon * _speed * Time.fixedDeltaTime);
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float _mousePosition = mouse.x;
        /*if (_mousePosition > transform.position.x && !_facingRight)
        {
            Flip();
        }
        else if(_mousePosition < transform.position.x && _facingRight)
        {
            Flip();
        }
        */
       // Debug.Log(_playerHealth);
    }
    void Flip()
    {
        _facingRight = !_facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
