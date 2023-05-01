using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    [SerializeField] private float _attackDistance;
    [SerializeField] private float _interactDistance;

    private Player _player;

    private void Awake()
    {
        _player = GetComponent<Player>();   
    }

    public void Attack()
    {
        var colliders = Physics2D.OverlapCircleAll(transform.position, _attackDistance);
        
        foreach (var collider in colliders)
        {
            collider.gameObject.Route<SoulCharacter>(character => character.ApplyDamage());
            collider.gameObject.Route<Grass>(grass => grass.DestroyGrass(transform.position)); //Изменить с transform.position на collider который мы задели взмахом
        }
    }

    public void InteractWithSoul()
    {
        var colliders = Physics2D.OverlapCircleAll(transform.position, _interactDistance);
        
        foreach (var collider in colliders)
        {
            
            collider.gameObject.Route<SoulCharacter>(_player.SoulAdd);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _attackDistance);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, _interactDistance);
    }
}
