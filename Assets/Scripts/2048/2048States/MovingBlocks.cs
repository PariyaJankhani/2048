using UnityEngine;
using UnityEngine.Assertions.Must;
using static UnityEditor.PlayerSettings;

public class MovingBlocks : BaseStates 
{

    private GameManager manager;
    private GridData GridData;
    //float duration = 0.5f;

    

    public override void OnEnter(GameManager manage)
    {
        Debug.Log("here is moving block");
       
        for (int x = 0; x < manage.Gridx; x++) 
        {
            for (int y = 0; y < manage.Gridy; y++)
            {
               
                if (manage.gridList[x, y] != null)
                {
                    
                    if (manage.gridList[x, y].tile2 != null)
                    {
                        
                        manage.gridList[x, y].tile2.Move();
                    }
                }
            }
       
        }
    }


        
    public override void OnExit(GameManager manage)
    {

    }
    public override void UpdateState(GameManager manage)
    {
       
       
    }

   
}
