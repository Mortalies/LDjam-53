using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulAnimation : MonoBehaviour
{
    [SerializeField] private AudioSource _deathAudio;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void DeathAnimation()
    {
        _animator.SetTrigger("Death");
        _deathAudio.Play();
    }

    public void DestroySoul()
    {
        Destroy(this.gameObject);
    }
}
