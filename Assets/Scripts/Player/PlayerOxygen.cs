using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOxygen : MonoBehaviour
{
    //Altered
    public Slider alteredBar;
    public float alteredAmount;
    float currentAltered;
    public Image alteredWarning;
  
     //Oxygen
    public Slider oxygenBar;
    public float oxygenAmount;
    float currentOxygen; 
    public Image Target_Image;
    
    PlayerController controller;

    public void Start() {
        currentAltered = 0;
        currentOxygen = oxygenAmount;
        controller = GetComponent<PlayerController>();
        
    }

    
    public void Update() {

        if(GameManager.sharedInstance.currentGameState == GameState.task 
        || GameManager.sharedInstance.currentGameState == GameState.inGame)
        {
            OxygenDecreased();
            StateAlteredDecreased();
          
            if(currentAltered >= 75){
                alteredWarning.GetComponent<Image>().color = new Color32 (171, 43 ,57, 255);
                if(currentAltered >= alteredAmount){
                    currentOxygen -= 0.009f * 2;
                }
            }

            if(currentOxygen <= 25)
            {
                Target_Image.GetComponent<Image>().color = new Color32 (171, 43 ,57, 255);
                if(currentOxygen <= 0)
                {
                    controller.PlayerDead();
                }
            }
        }
    }
    public void StateAlteredDecreased(){
        currentAltered += 0.009f;
        alteredBar.value = currentAltered/alteredAmount;
    }

    public void OxygenDecreased(){
        currentOxygen -= 0.009f;
        oxygenBar.value = currentOxygen/oxygenAmount;
    }

    public void BoostedKit(){
        currentAltered -= 5f;
    }
      
}
