using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    //Player Controller
    public float MovementSpeed;
    //public float JumpForce;
    
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() 
    {
        if(GameManager.sharedInstance.currentGameState == GameState.inGame)
        {

            var movement = Input.GetAxis("Horizontal");

            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
                
            /*if(!Mathf.Approximately(0, movement))
                transform.rotation = movement <  0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

            if(Input.GetButtonDown("Jump") && Mathf.Abs (rb.velocity.y) < 0.001f){
                
                rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }*/

        }
    }
}
