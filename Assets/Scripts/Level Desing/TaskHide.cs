using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskHide : MonoBehaviour
{
    public GameObject taskHide;

    public void TASKHIDE()
    {
        if(GameManager.sharedInstance.currentGameState == GameState.task ||
        GameManager.sharedInstance.currentGameState == GameState.inGame)
        {
        GameManager.sharedInstance.currentGameState = GameState.inGame;
        taskHide.SetActive(false);
        }
    }
}
