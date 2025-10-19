using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using static GridData;

public class GridManager : MonoBehaviour
{
    [SerializeField] private Tile tilePrefab;
    [SerializeField] private Tile2 tile2Prefab;
    [SerializeField] private Transform cam;
    Vector2 randomPosition;

    public GridData GridData { get; private set; }

    public void Initialize(GridData data)
    {
        this.GridData = data;
    }

    public void GenerateGrid()
    {
        for (int x = 0; x < GridData.Grid_size; x++) {

            for (int y = 0; y < GridData.Grid_size; y++) {

                Tile SpawnedTile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);
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


        


        var spawnedTile2 = Instantiate(tile2Prefab, new Vector3(pos.x, pos.y), Quaternion.identity);
       
        GridData.physicalGrid[pos.x, pos.y] = spawnedTile2;

       
    }


    private List<int> ProcessTile(List<int> line)
    {
        List<int> nonezerotile = new List<int>();
        foreach (int tilevalue in line) 
        { 
          if (tilevalue > 0)
            {
                nonezerotile.Add(tilevalue);
            }
        }

        List<int>mergedline = new List<int>();

        for (int i = 0; i < nonezerotile.Count; i++)
        {
            if (i < nonezerotile.Count - 1)
            {
                if (nonezerotile[i] == nonezerotile[i + 1])
                {
                    mergedline.Add(nonezerotile[i] * 2);
                    i++;
                }
                else
                {
                    mergedline.Add(nonezerotile[i]);
                }
            }
            else
            {
                mergedline.Add(nonezerotile[i]);
            }

        }

        int zerosToadd = GridData.Grid_size - mergedline.Count;
        for(int i=0 ;  i < zerosToadd; i++)
        {
            mergedline.Add(0);
        }

        return mergedline;

    }




}

