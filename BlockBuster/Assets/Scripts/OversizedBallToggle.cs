
using UnityEngine;
using UnityEngine.UI;

public class BigBallToggle : MonoBehaviour
{
    public Toggle oversizedBall;
    public static Vector3 ballSize= new Vector3(1,1,1);
    public static bool bigBall = false;

    public void setSize()
    {
        if (oversizedBall.isOn)
        {
            ballSize = new Vector3(3,3,3);
            bigBall = true;
            Debug.Log("true");
        }
        else
        {
            ballSize= new Vector3(1,1,1);
            bigBall = false;
            Debug.Log("false");
        }
    }
}
