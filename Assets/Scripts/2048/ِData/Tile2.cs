using UnityEngine;
using TMPro;
using NUnit.Framework;
using System.Collections.Generic;
public class Tile2 : MonoBehaviour
{
    public Vector3 targetPosition;
    float duration = 0.5f;



    private void Awake()
    {
        EventBroker.instance.OnNumberMove += Move;
    }

    private void Move()
    {

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("down!");
            LeanTween.moveY(gameObject, transform.position.y,duration);

        }



        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("up");


        }



        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("left!");


        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("right!");

        }
    }

}




