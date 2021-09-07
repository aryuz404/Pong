using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{
    public PlayerControl player;
    [SerializeField]
    private GameManager gameManager;
    
    void OnTriggerEnter2D(Collider2D otherCollider)    
    {
        if(otherCollider.name == "Ball")
        {
            player.IncrementScore();

             if(player.Score < gameManager.maxScore)
             {
                 otherCollider.gameObject.SendMessage("RestartGame", 2.0f, SendMessageOptions.RequireReceiver);
             }
        }
    }

}//class
