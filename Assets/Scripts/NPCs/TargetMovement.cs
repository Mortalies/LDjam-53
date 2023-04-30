using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]private Transform _target;
    [SerializeField] private float _speed;
    [SerializeField] private float _followRadius;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
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
        Vector3 dir = Vector3.Lerp(rb.position, _target.position*_followRadius, _speed * Time.deltaTime);
        rb.MovePosition(dir);
    }
}
