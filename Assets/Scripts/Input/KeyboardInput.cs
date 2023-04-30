using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerAnimation _playerAnimation;
    [SerializeField] private PlayerInteractor _playerInteractor;

    private void FixedUpdate()
    {
        _playerMovement.MoveDirection(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if (Input.GetKeyDown(KeyCode.E))
        {
            _playerAnimation.PlayAttack();
            _playerInteractor.Attack();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _playerInteractor.InteractWithNPC();
        }
            
    }
}
