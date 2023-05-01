using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(KeyboardInput))]
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerAnimation))]
[RequireComponent(typeof(PlayerInteractor))]
public class Player : MonoBehaviour
{
    [SerializeField] private int _soulsBag;
    
    [SerializeField]private List<SoulCharacter> _souls = new List<SoulCharacter>();

    private PlayerAnimation _animation;
    private PlayerMovement _movement;
    private PlayerInteractor _interactor;
    
    public PlayerAnimation Animation => _animation;
    public PlayerMovement Movement => _movement;
    public PlayerInteractor Interactor => _interactor;

    private void Update()
    {
        //if (_souls == null)
        //    return;
        
        foreach (var soul in _souls)
        {
            Debug.Log("Soul moved");
            var position = transform.position + (soul.transform.position - transform.position) *
                (soul.Movemet.FollowRadius / (transform.position - soul.transform.position).magnitude);
            soul.Movemet.MoveToWards(position);
        }
    }
    public void SoulAdd(SoulCharacter soul)
    {
        Debug.Log("soul added to bag");
        if(!_souls.Contains(soul) && _souls.Count < _soulsBag)
            _souls.Add(soul);
        soul.OnSoulMetDeath += DeleteSoulFormBag;
    }
    public void DeleteSoulFormBag(SoulCharacter soul)
    {
        _souls.Remove(soul);
    }
    private void Awake()
    {
        _animation = GetComponent<PlayerAnimation>();
        _interactor = GetComponent<PlayerInteractor>();
        _movement = GetComponent<PlayerMovement>();
    }
}
