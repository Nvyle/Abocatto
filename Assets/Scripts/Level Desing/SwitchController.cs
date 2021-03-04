using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchController : MonoBehaviour
{
    public GameObject Switch;
    public GameObject MessagePanel;

    void OnTriggerStay2D(Collider2D other)
    {
        if(GameManager.sharedInstance.currentGameState == GameState.inGame){
            if(other.tag == "Player" && Input.GetKey(KeyCode.E))
            {
                GameManager.sharedInstance.currentGameState = GameState.menu;
                Switch.SetActive(true);
            }

            MessagePanel.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player"){
        Switch.SetActive(false);
        MessagePanel.SetActive(false);
        }
    }

    
}
