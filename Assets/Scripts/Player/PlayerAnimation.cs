using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Diagnostics;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public void PlayMoveAnimation(Vector2 direction)
    {
        _animator.SetFloat("Horizontal", direction.x);
        _animator.SetFloat("Vertical", direction.y);
        _animator.SetFloat("Speed", direction.sqrMagnitude);
    }

    public void PlayAttackAnimation()
    {
        _animator.SetBool("Attack", true);
        StartCoroutine(AttackCorutine());
    }

    private IEnumerator AttackCorutine()
    {
        var clip = _animator.GetCurrentAnimatorClipInfo(0)[0].clip;
        
        yield return new WaitForSeconds(clip.length);
        
        _animator.SetBool("Attack", false);
    }
}
