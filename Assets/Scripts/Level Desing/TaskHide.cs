using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskHide : MonoBehaviour
{
    public GameObject taskHide;

    public void TASKHIDE()
    {
        GameManager.sharedInstance.currentGameState = GameState.inGame;
        taskHide.SetActive(false);
    }
}
