using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(KeyboardInput))]
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerAnimation))]
[RequireComponent(typeof(PlayerInteractor))]
public class Player : MonoBehaviour
{
    [SerializeField] private int _soulsBag;
    
    private List<SoulCharacter> _souls = new List<SoulCharacter>();

    private PlayerAnimation _animation;
    private PlayerMovement _movement;
    private PlayerInteractor _interactor;
    
    public PlayerAnimation Animation => _animation;
    public PlayerMovement Movement => _movement;
    public PlayerInteractor Interactor => _interactor;

    private void Update()
    {
        if (_souls == null)
            return;
        
        foreach (var soul in _souls)
        {
            var position = transform.position + (soul.transform.position - transform.position) *
                (soul.SoulMovement.FollowRadius / (transform.position - soul.transform.position).magnitude);
            soul.SoulMovement.MoveToWards(position);
        }
    }

    public void SoulAdd(SoulCharacter soul)
    {
        if(!_souls.Contains(soul) && _souls.Count > _soulsBag)
            _souls.Add(soul);
    }
    private void Awake()
    {
        _animation = GetComponent<PlayerAnimation>();
        _interactor = GetComponent<PlayerInteractor>();
        _movement = GetComponent<PlayerMovement>();
    }
}
