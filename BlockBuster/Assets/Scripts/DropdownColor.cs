using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownColor : MonoBehaviour
{
    public Dropdown setColor;
    public static Color ballColor = new Color32(255, 0, 255,128);
    public void selectColor()
    {
        switch (setColor.value)
        {
            case 1:
            ballColor = new Color32(255,0,0,128);
            Debug.Log(ballColor);
            break;

            case 2:
            ballColor = new Color32(0,255,0,128);
            Debug.Log(ballColor);
            break;

            case 3:
            ballColor = new Color32(0,0,255,128);
            Debug.Log(ballColor);
            break;

            default:
            ballColor = new Color32(255, 0, 255,128);
            Debug.Log(ballColor);
            break;


        }
    }
}
