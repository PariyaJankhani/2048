using UnityEngine;
using TMPro;
public class Tile2 : MonoBehaviour
{
  


    [SerializeField] private TextMeshProUGUI valueText; 
    [SerializeField] private SpriteRenderer tileRenderer; 

    public int Value { get; private set; }


    public void SetValue(int newValue)
    {
        this.Value = newValue;

        if (valueText != null)
        {
            valueText.text = newValue.ToString();
        }

        if (tileRenderer != null)
        {
            tileRenderer.color = GetColorByValue(newValue);
        }

      
    }

    private Color GetColorByValue(int value)
    {
        switch (value)
        {
            case 2: return Color.magenta;
            case 4: return Color.yellow;
            case 8: return Color.green;
            case 16: return Color.blue;
            case 2048: return Color.red;
            default: return Color.gray;
        }
    }
}




