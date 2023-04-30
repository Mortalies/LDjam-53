using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    [SerializeField] private float _followRadius;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (_target != null)
            MoveToTarget();
    }
    
    public void SetTarget(Transform target)
    {
         _target = target;
    }
    
    private void MoveToTarget()
    {
        Vector3 dir = Vector3.Lerp(_rigidbody.position, _target.position*_followRadius, _speed * Time.deltaTime);
        _rigidbody.MovePosition(dir);
    }
}
