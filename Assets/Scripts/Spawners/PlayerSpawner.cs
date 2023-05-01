using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private Player _prefab;
    [SerializeField] private List<Transform> _spawnPositions;
    public event Action<Player> OnPlayerSpawned;
    
    public static PlayerSpawner Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        SpawnPlayer();
    }

    private Player SpawnPlayer()
    {
        var instance = Instantiate(_prefab, _spawnPositions.RandomItem().position, Quaternion.identity);
        OnPlayerSpawned?.Invoke(instance);
        return instance;
    }
}
