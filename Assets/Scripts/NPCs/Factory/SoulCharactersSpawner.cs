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
<<<<<<<< Updated upstream:Assets/Scripts/NPCs/SoulCharactersSpawner.cs
        factory = new SoulCharactersFactory();
========
        //factory = new SoulCharactersFactory();
>>>>>>>> Stashed changes:Assets/Scripts/NPCs/Factory/SoulCharactersSpawner.cs
        SpawnSoul();
    }
    public void SpawnSoul()
    {
        Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count-1)];
        SoulCharacterConfig config = _configs[Random.Range(0, _configs.Count-1)];
        factory.Spawn(config, spawnPoint.position);
    }
    void Update()
    {
        
    }
}
