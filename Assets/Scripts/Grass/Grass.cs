using UnityEngine;
using UnityEngine.Tilemaps;
public class Grass : MonoBehaviour
{
    [SerializeField] Tilemap tilemap;
    private void Start()
    {
        tilemap = GetComponent<Tilemap>();
    }
    public void DestroyGrass(Transform pos)
    {
        Vector3Int tilePos = tilemap.WorldToCell(pos.position);
        tilemap.SetTile(tilePos,null);
        
    }
    
}
