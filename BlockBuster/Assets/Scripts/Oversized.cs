using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oversized : MonoBehaviour
{
    public Toggle oversizedBall;
    public static bool bigBall = false;

    public void setSize()
    {
        if (oversizedBall.isOn)
        {
            bigBall = true;
            Debug.Log("true");
        }
        else
        {
            bigBall = false;
            Debug.Log("false");
        }
    }
}


