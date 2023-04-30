using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCharactersSpawner : MonoBehaviour
{
    SoulCharactersFactory factory;
    [SerializeField] private List<SoulCharacterConfig> _configs = new List<SoulCharacterConfig>();
    [SerializeField] private List<Transform> _spawnPoints = new List<Transform>();
    void Start()
    {
        factory = new SoulCharactersFactory();
        SpawnSoul();
    }
    public void SpawnSoul()
    {
        Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count-1)];
        SoulCharacterConfig config = _configs[Random.Range(0, _configs.Count-1)];
        factory.Spawn(config, spawnPoint.position);
    }
}
