using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCharactersSpawner : MonoBehaviour
{
    [SerializeField] SoulCharactersFactory factory;
    [SerializeField] private List<SoulCharacterConfig> _configs = new List<SoulCharacterConfig>();
    [SerializeField] private List<Transform> _spawnPoints = new List<Transform>();

    void Start()
    {
        SpawnSoul();
    }
    public void SpawnSoul()
    {
        Transform spawnPoint = _spawnPoints.RandomItem();
        SoulCharacterConfig config = _configs.RandomItem();
        factory.Spawn(config, spawnPoint.position);
    }
}
