using UnityEngine;

public class movetile2 : MonoBehaviour 
{
    [SerializeField] Transform targetTransform;
    [SerializeField] float duration;
    

    public GridManager gridManager { get; private set; }
    
    
    public void Initialize(GridManager gridManager)
    {
        this.gridManager = gridManager;
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow)) MoveRight();

        void MoveRight()
        {

            LeanTween.moveX(gameObject, transform.position.x , duration);

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)) MoveLeft();
        void MoveLeft()
        {
            LeanTween.moveX(gameObject, gridManager.Grid_sizex  , duration);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) MoveUp();
        void MoveUp() 
        {
            LeanTween.moveY(gameObject, gridManager.Grid_sizey , duration);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) MoveDown();
        void MoveDown()
        {
            LeanTween.moveY(gameObject, gridManager.Grid_sizey , duration);
        }

    }
}
