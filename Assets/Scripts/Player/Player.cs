using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(KeyboardInput))]
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerAnimation))]
[RequireComponent(typeof(PlayerInteractor))]
public class Player : MonoBehaviour
{
    [SerializeField] private FieldVeiw _fieldVeiw;
    [SerializeField] private float _sightDistance;
    
    private PlayerAnimation _animation;
    private PlayerMovement _movement;
    private PlayerInteractor _interactor;
    
    public PlayerAnimation Animation => _animation;
    public PlayerMovement Movement => _movement;
    public PlayerInteractor Interactor => _interactor;
    
    private void Awake()
    {
        _animation = GetComponent<PlayerAnimation>();
        _interactor = GetComponent<PlayerInteractor>();
        _movement = GetComponent<PlayerMovement>();
    }
    
    private void Start()
    {
        StartCoroutine(UpdateFieldView());
    }

    private IEnumerator UpdateFieldView()
    {
        while (true)
        {
            _fieldVeiw.MakeHole(transform.position, _sightDistance);
            yield return new WaitForSeconds(Constants.CHECK_INTERVAL);
        }
    }
}
