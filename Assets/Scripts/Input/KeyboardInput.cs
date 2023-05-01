using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Events;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] private Player _player;
    //public UnityEvent qDown;
    private bool _isMovementBlocked;
    private bool _isDialogueBlocked;
    private void Start()
    {
        //qDown = new UnityEvent();
    }
    private void FixedUpdate()
    {
        var direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _player.Movement.MoveDirection(direction);
        _player.Animation.PlayMoveAnimation(direction);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _player.Animation.PlayAttackAnimation();
            _player.Interactor.Attack();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _player.Interactor.InteractWithSoul();
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            DialogueController.instance.NextMessage();
        }
    }
}
