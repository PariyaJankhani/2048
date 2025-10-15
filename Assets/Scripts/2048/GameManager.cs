using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private int _width, _height;

    [SerializeField] private Tile tilePrefab;

    [SerializeField] private Transform cam;
    [SerializeField] private Tile2 tile2;


    Vector2 randomPosition;
    public float xrange = 1.5f;
    public float yrange = 1.0f;





    private Tile[,] Grid;

    public void Start()
    {
        Generategrid();
        FindEmptyTiles();

    }
    public void Generategrid()
    {

        Grid = new Tile[_width, _height];
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                var spawnedtile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedtile.name = $"tile {x} {y}";

                Grid[x, y] = spawnedtile;
            }
        }

        cam.transform.position = new Vector3((float)_width / 2 - 0.5f, _height / 2 - 1f, -10);


    }

    public void FindEmptyTiles()
    {
        List<Vector2> allGridPosition = new List<Vector2>();
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                Tile tile = Grid[x, y];
                allGridPosition.Add(new Vector2(x, y));

                if (tile.IsEmpty)
                {
                    Debug.Log($"Empty tile found at position: ({tile.transform.position.x}, {tile.transform.position.y})");

               
                    float xposition = UnityEngine.Random.Range(0,x);
                    float yposition = UnityEngine.Random.Range(0 , y);
                    int randomIndex = UnityEngine.Random.Range(0, allGridPosition.Count);
                    Vector2 randomPosition = allGridPosition[randomIndex];
                    Instantiate(tile2, randomPosition, Quaternion.identity);
                    return;
                    //if (tile2 != null)
                    //{
                    //    int randomIndex = UnityEngine.Random.Range(0, _width);
                    //    int randomIndey = UnityEngine.Random.Range(0, _height);
                    //    Vector2 randomPosition = new Vector2 (randomIndex,randomIndey);

                    //    Instantiate(tile2, randomPosition, Quaternion.identity);
                    //}

                }
                } 

            }
        }
    }


