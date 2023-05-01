using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCharactersSpawner : MonoBehaviour
{
    [SerializeField] SoulCharactersFactory _factory;
    [SerializeField] private List<SoulCharacterConfig> _configs = new List<SoulCharacterConfig>();
    [SerializeField] private List<Transform> _spawnPoints = new List<Transform>();

    void Start()
    {
        while(_configs.Count!=0)
            SpawnSoul();
    }
    public void SpawnSoul()
    {
        if (_factory == null)
            return;
        
        Transform spawnPoint = _spawnPoints.RandomItem();
        _spawnPoints.Remove(spawnPoint);
        SoulCharacterConfig config = _configs.RandomItem();
        _configs.Remove(config);

        _factory.Spawn(config, spawnPoint.position);
    }
}
