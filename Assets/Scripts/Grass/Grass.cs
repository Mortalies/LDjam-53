using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.WSA;


public class Grass : MonoBehaviour
{
    [SerializeField] private TileBase _tileToSet;
    private Tilemap _map;
    
    private void Awake()
    {
        _map = GetComponent<Tilemap>();
    }
    
    public void DestroyGrass(Vector3 position)
    {
        Vector3Int cellPosition = _map.WorldToCell(position);
        if(_map.GetTile(cellPosition) != null)
            _map.SetTile(cellPosition, _tileToSet);
    } 
}
