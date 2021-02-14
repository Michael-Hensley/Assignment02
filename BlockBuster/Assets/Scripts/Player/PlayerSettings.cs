
using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    public Player myPlayer;
    public PlayerMovement playerSpeedx;
    void Awake()
    {
        //GameObject myPlayer = GameObject.FindWithTag("Player");

        Renderer myRenderer;
        myRenderer = myPlayer.GetComponent<Renderer>();
        myRenderer.material.SetColor("_Color", DropdownColor.ballColor);

        playerSpeedx.acceleration = PlayerSpeedSlider.playerSpeed;

        if (Oversized.bigBall)
        {
            myPlayer.transform.localScale = new Vector3(2f,2f,2f);
            myPlayer.health = 10;
        }
        else
        {
            myPlayer.transform.localScale = new Vector3(1f,1f,1f);
            myPlayer.health = 2;
        }
    }  
}