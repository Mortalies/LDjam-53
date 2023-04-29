using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField] float _speed;
    public void MoveDirection(Vector3 direction)
    {
        _rigidbody.MovePosition(_rigidbody.position + (direction * _speed * Time.deltaTime));
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
}
