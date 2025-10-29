using UnityEngine;
using TMPro;
using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
public class Tile2 : MonoBehaviour
{

    //public Vector3 targetPosition ;
    public Vector2Int targetPosition;
    GridData GridData;
    public void Move()
    {
        //LeanTween.move(gameObject,GridData.gridPosition, 0.5f).setEaseInOutQuad();
        LeanTween.move(gameObject,GridData.gridPosition, 0.5f).setEaseInOutQuad();
        Debug.Log(GridData.gridPosition);
        Debug.Log("down!");
        
        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    Debug.Log("down!");



        //}



        //else if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    Debug.Log("up");


        //}



        //else if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    Debug.Log("left!");


        //}

        //else if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    Debug.Log("right!");

        //}
    }

}




