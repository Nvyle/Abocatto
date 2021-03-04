using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOxygen : MonoBehaviour
{
    public Slider oxygenBar;
    public float oxygenAmount;
    float currentOxygen;

    PlayerController controller;

    void Start() {
        currentOxygen = oxygenAmount;
        controller = GetComponent<PlayerController>();
    }

    void OxygenDecreased(){
        currentOxygen -= 0.009f;
        oxygenBar.value = currentOxygen/oxygenAmount;
    }
    
    void Update() {

        if(GameManager.sharedInstance.currentGameState != GameState.intro 
        && GameManager.sharedInstance.currentGameState != GameState.gameOver
        && GameManager.sharedInstance.currentGameState != GameState.menu)
        {
            OxygenDecreased();
        }
    }
}
