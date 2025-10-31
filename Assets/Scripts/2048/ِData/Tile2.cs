using UnityEngine;
using TMPro;
using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
public class Tile2 : MonoBehaviour
{
    Transform move;
    GameManager gameManager;
    //public Vector3 targetPosition;
    public Vector3 targetPosition;
    public GridData GridData;

    private void Start()
    {
        

    }
    public void Move()
    {

        //targetPosition = GridData.gridPosition;
        //LeanTween.move(gameObject,GridData.gridPosition, 0.5f).setEaseInOutQuad(); 
        Vector3 finalPos = new Vector3(targetPosition.x, targetPosition.y, 0);
        LeanTween.move( gameObject,finalPos, 0.5f).setEaseInOutQuad();
        //LeanTween.move(gameObject,, 0.5f).setEaseInOutQuad();
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




