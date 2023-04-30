using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    
    private void FixedUpdate()
    {
        _playerMovement.MoveDirection(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }
}
