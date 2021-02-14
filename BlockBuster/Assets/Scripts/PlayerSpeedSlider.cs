using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpeedSlider : MonoBehaviour
{
    public static float playerSpeed = 500;
    public Slider speedSlider;

    public void selectSpeed()
    {
        switch (speedSlider.value)
        {
            case 1:
            playerSpeed = 500;
            Debug.Log(playerSpeed);
            break;

            case 2:
            playerSpeed = 1000;
            Debug.Log(playerSpeed);
            break;

            case 3:
            playerSpeed = 1500;
            Debug.Log(playerSpeed);
            break;

            case 4:
            playerSpeed = 2000;
            Debug.Log(playerSpeed);
            break;


        }
    }
}
