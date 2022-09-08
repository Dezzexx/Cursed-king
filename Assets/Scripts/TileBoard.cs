using System.Collections.Generic;
using UnityEngine;

public class TileBoard : MonoBehaviour
{
    [SerializeField] private List<Vector2> _spawnPoints = new List<Vector2>();
    public int SpawnPointCount => _spawnPoints.Count;
    
    public Vector2 GetSpawnPoint(int index)
    {
        return _spawnPoints[index];
    }

    // public Vector2 GetTowerPlacement()
    // {

    // }
}
