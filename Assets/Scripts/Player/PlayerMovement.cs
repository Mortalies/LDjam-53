using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    [SerializeField] private float _speed;
    
    public void MoveDirection(Vector2 direction)
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + (direction * _speed * Time.deltaTime));
    }

    public void SlowMoveSpeed(float slow)
    {
        _speed *= slow;
    }

    public void SetToDefualt(float slow)
    {
        _speed /= slow;
    }
    
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
}
