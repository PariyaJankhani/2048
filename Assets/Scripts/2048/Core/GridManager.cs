using System.Collections.Generic;
using UnityEngine;
//using static GridData;

public class GridManager : MonoBehaviour
{
    [SerializeField] private Tile tilePrefab;
    [SerializeField] private Tile2 tile2Prefab;
    [SerializeField] private Transform cam;
    Vector2 randomPosition;

    public GridData GridData {  get; private set; }

    public void Initialize(GridData data)
    {
        this.GridData = data;
    }

    public void GenerateGrid()
    {
        for (int x = 0; x < GridData.Grid_size; x++) {

            for (int y = 0; y < GridData.Grid_size; y++) {
            
                Tile SpawnedTile = Instantiate(tilePrefab, new Vector3(x,y),Quaternion.identity);
                SpawnedTile.name = $"tile{x} {y}";

            }

        }
        cam.transform.position = new Vector3((float)GridData.Grid_size / 2 - 0.5f, GridData.Grid_size / 2 - 1f, -10);

    }

    public void SpawnRandomTile()
    {
        
        List<Vector2Int> emptyPositions = new List<Vector2Int>();

        for (int x = 0; x < GridData.Grid_size; x++)
        {
            for (int y = 0; y < GridData.Grid_size; y++)
            {
               
                if (GridData.LogicGrid[x, y] == 0)
                {
                    emptyPositions.Add(new Vector2Int(x, y));
                }
            }
        }

        if (emptyPositions.Count == 0)
        {
            Debug.Log("No empty spots left. Game Over check needed.");
            return;
        }

       
        int randomIndex = Random.Range(0, emptyPositions.Count);
        Vector2Int pos = emptyPositions[randomIndex];

        
        int value = (Random.Range(0f, 1f) < 0.9f) ? 2 : 4;

       
        var spawnedTile2 = Instantiate(tile2Prefab, new Vector3(pos.x, pos.y), Quaternion.identity);
        spawnedTile2.SetValue(value);

        GridData.LogicGrid[pos.x, pos.y] = value;
        GridData.physicalGrid[pos.x, pos.y] = spawnedTile2;

        Debug.Log($"Tile {value} spawned at ({pos.x}, {pos.y})");
    }
}

