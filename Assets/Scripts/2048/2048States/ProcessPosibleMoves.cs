using NUnit.Framework;
using Unity.Mathematics;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEngine.GraphicsBuffer;

public class ProcessPosibleMoves: BaseStates
{
    Tile tile;
    Tile2 tile2;
    public override void OnEnter(GameManager manage)
    {
        Debug.Log("here is process possible moves");
        UpdateState(manage);
       
    }
    public override void OnExit(GameManager manage)
    {

    }
    public override void UpdateState(GameManager manage)
    {
        int size = manage.gridList.GetLength(0);

        //int startX, endX, stepx;
        //int startY, endY, stepy;
        //if (manage.currentDirection == MoveDirection.Right)
        //{
        //    startX = size - 2;
        //    endX = -1;
        //    stepx = -1;
        //}
        //else if(manage.currentDirection == MoveDirection.Left)
        //{
        //    startX = 1;
        //    endX = size;
        //    stepx = 1;
        //}
        //else
        //{
        //    startX = 1;
        //    endX = size;
        //    stepx = 1;
        //}

        //if (manage.currentDirection == MoveDirection.Down)
        //{
        //    startY = size - 2;
        //    endY = -1;
        //    stepy = -1;
        //}
        //else if(manage.currentDirection == MoveDirection.Up)
        //{
        //    startY = 1;
        //    endY= size;
        //    stepy = 1;
        //}
        //else
        //{
        //    startY = 1;
        //    endY = size;
        //    stepy = 1;
        //}


        for (int x = 0; x != size; x++)

        {
            int m = 0;
          

                for (int y=0; y != size; y++)

                {
                    GridData currentTile = manage.gridList[x, y];

                if (currentTile.tile2 != null)
                {
                    currentTile.tile2.targetPosition = new Vector2Int(x, m);



                //currentTile.gridPosition = new Vector3(x, m, 0);
                manage.gridList[x, m] = new GridData
                {
                    gridPosition = new Vector3(x, m, 0),
                };

                manage.gridList[x, m] = currentTile;
                    manage.gridList[x, y] = null;
                    //m++;



                    Debug.Log($"Tile2{manage.gridList[x,m]}moved to :{x},{m}");


                }
                //else
                //{
                //    Debug.Log($"Empty cell at :{x}, {y}");
                //}



            }




            //if (currentTile != null) continue;
            //currentTile.tile.merged = false;
            //int nextX = x;
            //int nextY = y;

            //while (true)
            //{
            //int targetX = nextX;
            //int targetY = nextY;

            //    if (manage.currentDirection == MoveDirection.Left)
            //        targetX = nextX - 1;

            //    else if (manage.currentDirection == MoveDirection.Right)
            //        targetX = nextX + 1;

            //    if (manage.currentDirection != MoveDirection.Up)
            //        targetX = nextX - 1;

            //    else if (manage.currentDirection != MoveDirection.Down)
            //        targetX = nextX + 1;

            //    if (targetX < 0 || targetX >= size || targetY < 0 || targetY >= size)
            //        break;

            //GridData targetTile = manage.gridList[targetX, targetY];


            //    if (targetTile == null)
            //    {
            //        currentTile.tile.targetPos = new Vector2Int(targetX, targetY);

            //        nextX = targetX;
            //        nextY = targetY;
            //        Debug.Log(currentTile);


            //    }
            //    else if (targetTile.tile.value == currentTile.tile.value && !targetTile.tile.merged)
            //    {
            //        currentTile.tile.targetPos = new Vector2Int(targetX, targetY);

            //        currentTile.tile.merged = true;
            //        targetTile.tile.merged = true;
            //    Debug.Log(currentTile);


            //}
            //else
            //{
            //    break;
            //}
            //}




        }

        manage.ChangeState(manage.movingBlocks);
        manage.movingBlocks.OnEnter(manage);



    }


    }
    










//   if(manage.currentDirection == MoveDirection.Up)
//    {
//        for(int i = 0; i< manage.Gridy; i++)
//        {

//        }
//    }
//   if(manage.currentDirection == MoveDirection.Down)
//    {

//    }
//   if(manage.currentDirection== MoveDirection.Left)
//    {

//    }
//   if(manage.currentDirection== MoveDirection.Right)
//    {

//    }

//    manage.ChangeState(manage.movingBlocks);


