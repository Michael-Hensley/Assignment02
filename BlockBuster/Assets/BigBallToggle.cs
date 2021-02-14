using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OversizedBallToggle : MonoBehaviour
{
    public Toggle oversizedBall;
    public static Vector3 ballSize;

    public void setSize()
    {
        if (oversizedBall.isOn)
        {
            ballSize = new Vector3(2,2,2);
            Debug.Log(ballSize);
        }
        else
        {
            ballSize= new Vector3(1,1,1);
            Debug.Log(ballSize);
        }
    }
}
