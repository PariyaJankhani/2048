using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Tile tilePrefab;
    [SerializeField] public Tile2 Tile2prefab;
    [SerializeField] private Transform cam;

    public GridData[,] gridList;
    [SerializeField] public int Gridx;
    [SerializeField] public int Gridy;

    public BaseStates currentState;
    public WaitForInput input = new WaitForInput();
    public ProcessPosibleMoves posibleMoves = new ProcessPosibleMoves();
    public MovingBlocks movingBlocks = new MovingBlocks();
    public CompleteTheGrid completeTheGrid = new CompleteTheGrid();
    public CheckComplete checkComplete = new CheckComplete();

    public MoveDirection currentDirection;

    //------------------
    public  GameManager instance { get; private set; }
    /*    [SerializeField] public GridManager gridManager;
        private GridData gridData;*/

    public void Awake()
    {
        instance = this;

    }

    public void Start()
    {
        /*        gridData = new GridData();
        */
       
        initGridData();
        ChangeState(input);



        /*        gridManager.GenerateGrid();

                if (gridManager == null)
                    gridManager = GetComponent<GridManager>();

                //if (gridManager != null && gridData != null)
                //{
                    //gridManager.GenerateGrid();
                    gridManager.Initialize(gridData);

                //}


                ChangeState(gameObject.AddComponent<GenerateInitialState>());*/
    }
    private void initGridData()
    {
        //gridList  مقدار دهی اولیه به

        gridList = new GridData[Gridx, Gridy];

        //-------------------------

        // gridListساخت تایل های پایه  بر اساس سایز برد و دادن رفرنس تایل ها به 

        for (int x = 0; x < Gridx; x++)
        {
            for (int y = 0; y < Gridy; y++)
            {
                Tile tileinstance = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);
               
                gridList[x, y] = new GridData
                {
                    tile = tileinstance,
                    gridPosition = new Vector3(x, y)
                };

            }



        }
       cam.transform.position = new Vector3((float)Gridx / 2 - 0.5f, Gridy / 2 - 1f, -10);

        int[,] logicalgrid = new int[Gridx, Gridy];
        List<Vector2Int> emptyPositions = new List<Vector2Int>();

        for (int x = 0; x < Gridx; x++)
        {
            for (int y = 0; y < Gridy; y++)
            {

                if (logicalgrid[x, y] == 0)
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

        int randomIndex = UnityEngine.Random.Range(0, emptyPositions.Count);
        Vector2Int pos = emptyPositions[randomIndex];
        logicalgrid[pos.x, pos.y] = 1;
        Tile2 tile = Instantiate(Tile2prefab, new Vector3(pos.x, pos.y), Quaternion.identity);
        gridList[pos.x, pos.y] = new GridData
        {
            tile2 = tile
        };
        
        
        // رفتن به استیت wait for input
        // ساخت enum برای جهت های input 

        //C:\unity\2048\Assets\Scripts\2048\ِData\MoveDirection.cs

        // گرفتن input
        // در استیت
        // wait for input

        // و ذخیره مقدار
        // enum
         
        //done--

        // و رفتن به استیت process possible moves


    }


    public void ChangeState(BaseStates newState)
    {
        currentState = input;
        currentState.OnEnter(this);


    }


    private void Update()
    {
        
    }



    //-------------------------

    //-------------------------
}


//List<Vector3Int> GetAllTilePositions()
//{
//    List<Vector3Int> poslist = new List<Vector3Int>();
//    foreach (Vector3Int pos in levelTilemap.cellBounds.allPositionsWithin)
//    {
//        if (levelTilemap.HasTile(pos))
//        {
//            poslist.Add(pos);
//        }

//    }

//    if (poslist.Count != 0)
//    {
//        gridData.gridPosition = GetAllTilePositions();
//    }
//    Debug.Log(GetAllTilePositions());
//    return poslist;


//}
        
       




   







