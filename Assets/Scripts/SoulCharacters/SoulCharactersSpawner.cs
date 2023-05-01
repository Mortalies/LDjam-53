using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCharactersSpawner : MonoBehaviour
{
    [SerializeField] SoulCharactersFactory _factory;
    [SerializeField] private List<SoulCharacterConfig> _configs = new List<SoulCharacterConfig>();
    [SerializeField] private List<Transform> _spawnPoints = new List<Transform>();
    [SerializeField] private List<SoulCharacter> _souls = new List<SoulCharacter>();
    
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

        _souls.Add(_factory.Spawn(config, spawnPoint.position));
        GameStart.instance.setSouls(_souls);
    }
}
