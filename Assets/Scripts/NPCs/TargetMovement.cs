using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    [SerializeField] private float _followRadius;
    [SerializeField] private bool isAttached = false;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (_target != null && isAttached)
            MoveToTarget();
    }
    public void SetTarget(Transform target)
    {
        _target = target;
    }
    public void ActivateMovement()
    {
        isAttached = true;
    }
    
    private void MoveToTarget()
    {
        //Vector2 dir = Vector2.Lerp(_rigidbody.position, _target.position*_followRadius, _speed * Time.deltaTime);
        //_rigidbody.MovePosition(dir);
        _rigidbody.velocity = Vector2.Lerp(_rigidbody.position,_target.position*_followRadius, _speed * Time.deltaTime);
    }
}
