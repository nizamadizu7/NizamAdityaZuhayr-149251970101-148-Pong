using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalePaddleController : MonoBehaviour
{
    
    public PowerUpManager manager;
    public Collider2D ball;

    public Paddle paddle1,paddle2;

    public BallController bola;

    private void OnTriggerEnter2D(Collider2D other) {
        
            if(bola.nama==true){
                StartCoroutine(scaleup(paddle2));
            }else{
                StartCoroutine(scaleup(paddle1));
            }
       
        
        manager.RemovePowerUp(gameObject);
            
        }
    IEnumerator scaleup(Paddle paddle){
        paddle.transform.localScale=new Vector3(0.5f,4,0);
        yield return new WaitForSeconds(5);
        paddle.transform.localScale=new Vector3(0.5f,2,0);
    }
}
