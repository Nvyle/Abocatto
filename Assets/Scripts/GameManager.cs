using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{
    intro,
    task,
    menu,
    inGame,
    gameOver
}

public class GameManager : MonoBehaviour
{

    public GameState currentGameState = GameState.intro;

    public static GameManager sharedInstance;

    private PlayerController controller;

    void Awake()
    {
        if(sharedInstance == null){
            sharedInstance = this;
        }

        StartCoroutine (WaitSys ());
    }

     void Start()
    {
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
       /*if(Input.GetButtonDown("Submit") && currentGameState != GameState.inGame){
            StartGame();
        }*/
    }

    IEnumerator WaitSys(){
        yield return new WaitForSeconds(5f);
        currentGameState = GameState.inGame;
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

        }else if(newGameState == GameState.inGame)
        {
            //TODO: hay que preparar la escena para jugar

        } else if(newGameState == GameState.gameOver){

            //TODO: preparar el juego para Game Over.
        }

        this.currentGameState = newGameState;
    }
}
