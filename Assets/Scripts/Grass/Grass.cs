using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.WSA;


public class Grass : MonoBehaviour
{
    [SerializeField] private TileBase _tileToSet;
    [SerializeField] private GrassAnimation _animation;
    
    private Tilemap _map;
    
    private void Awake()
    {
        _map = GetComponent<Tilemap>();
    }
    
    public void DestroyGrass(Vector3 position)
    {
        Vector3Int cellPosition = _map.WorldToCell(position);
        if (_map.GetTile(cellPosition) != null)
        {
            var spawnPosition = new Vector3(cellPosition.x + 0.5f, cellPosition.y + 0.5f, 0f);
            _map.SetTile(cellPosition, _tileToSet);
            Instantiate(_animation, spawnPosition, Quaternion.identity);
        }
            
    } 
}
