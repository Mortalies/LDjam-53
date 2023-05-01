using System;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayMoveAnimation(Vector2 direction)
    {
        _animator.SetFloat("Horizontal", direction.x);
        _animator.SetFloat("Vertical", direction.y);
        _animator.SetFloat("Speed", direction.magnitude);
    }

    public void PlayAttackAnimation()
    {
        _animator.SetBool("Attack", true);
    }

    public void StopAttackAnimation()
    {
        _animator.SetBool("Attack", false);
    }
}
