using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    //Player Controller
    public float MovementSpeed;
    Animator animator;
    //public float JumpForce;

    public bool OnLadder { get; set;}

    [SerializeField]
    private float climSpeed;
    
    private void Start() {
        OnLadder = true;
        rb = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    private void FixedUpdate() 
    {
        if(GameManager.sharedInstance.currentGameState == GameState.inGame)
        {
            var movement = Input.GetAxis("Horizontal");


            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

                
            if(!Mathf.Approximately(0, movement))

                transform.rotation = movement <  0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
                animator.SetFloat ("Speed", Mathf.Abs(movement));

           /* if(Input.GetButtonDown("Jump") && Mathf.Abs (rb.velocity.y) < 0.001f){
                
                rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }*/
        }
    }
    private void HandleMovement(float movement){
         
         if (OnLadder){
            rb.velocity = new Vector2(movement * )
         }

    }
    
    public void PlayerDead(){
        GameManager.sharedInstance.GameOver();
    }
}
