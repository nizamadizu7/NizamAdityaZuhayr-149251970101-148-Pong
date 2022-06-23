using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPaddleController : MonoBehaviour
{
     
    public PowerUpManager manager;
    public Collider2D ball;

    public Paddle paddle1,paddle2;

    public BallController bola;

    private void OnTriggerEnter2D(Collider2D other) {
        
            if(bola.nama==true){
                StartCoroutine(speedUp(paddle2));
            }else{
                StartCoroutine(speedUp(paddle1));
            }
            manager.RemovePowerUp(gameObject);            
        }

    
    IEnumerator speedUp(Paddle paddle){
        paddle.speed*=2;
        yield return new WaitForSeconds(5);
        paddle.speed*=2;
    }
}