using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{
    menu,
    inGame,
    gameOver
}

public class GameManager : MonoBehaviour
{

    public GameState currentGameState = GameState.menu;

    public static GameManager sharedInstance;

    private PlayerController controller;

    void Awake()
    {
        if(sharedInstance == null){
            sharedInstance = this;
        }
        
    }
     void Start()
    {
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (currentGameState != GameState.inGame){
            StartGame();
        }
    }

    public void StartGame(){
        SetGameState(GameState.inGame);

    }

    public void GameOver(){
        SetGameState(GameState.gameOver);
    }

    public void BackToMenu(){
        SetGameState(GameState.menu);
    }

    private void SetGameState(GameState newGameState){
        if(newGameState == GameState.menu){
            
            //TODO: colocar la logica del menu
            //MenuManager.sharedInstance.ShowMainMenu();

        }else if(newGameState == GameState.inGame)
        {
            //TODO: hay que preparar la escena para jugar
            //MenuManager.sharedInstance.HideMainMenu();

        } else if(newGameState == GameState.gameOver){

            //TODO: preparar el juego para Game Over.
            //MenuManager.sharedInstance.ShowMainMenu();
        }

        this.currentGameState = newGameState;
    }
}
