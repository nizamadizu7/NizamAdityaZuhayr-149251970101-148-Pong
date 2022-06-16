using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float magnitude;
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision == ball) {
            ball.GetComponent<BallController>().SpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
