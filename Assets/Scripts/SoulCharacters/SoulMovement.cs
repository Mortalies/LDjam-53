using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class SoulMovement : MonoBehaviour
{
    
    
    [SerializeField] private float _speed;
    
    private Rigidbody2D _rigidbody;
    
    [SerializeField] private float _followRadius;
    public float FollowRadius => _followRadius;
    
    public void MoveToWards(Vector2 position)
    {
        if (position == null)
            return;
        
        var distance = Vector2.Distance(transform.position, position);
        if (distance > _followRadius)
        {
            transform.position =  Vector2.MoveTowards(transform.position, position, _speed * Time.deltaTime);
        }
        
    }
}
