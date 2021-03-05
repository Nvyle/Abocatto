using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOxygen : MonoBehaviour
{
    public Slider oxygenBar;
    public float oxygenAmount;
    float currentOxygen; 
    public Image Target_Image;
    
    
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

        if(GameManager.sharedInstance.currentGameState == GameState.task 
        || GameManager.sharedInstance.currentGameState == GameState.inGame)
        {
            OxygenDecreased();
            
            if(currentOxygen <= 25)
            {
                change_color();
                if(currentOxygen <= 0)
                {
                    controller.PlayerDead();
                }
            }
        }
    }

    public void change_color() 
    {
        Target_Image.GetComponent<Image>().color = new Color32 (171, 43 ,57, 255);
    } 
 
}
