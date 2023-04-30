using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void FixedUpdate()
    {
        var direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _player.Movement.MoveDirection(direction);
        _player.Animation.PlayMoveAnimation(direction);
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            _player.Animation.PlayAttackAnimation();
            _player.Interactor.Attack();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _player.Interactor.InteractWithNPC();
        }
            
    }
}
