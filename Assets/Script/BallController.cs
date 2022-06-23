using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector2 speed;
    public Vector2 resetPosition;
    private PUSpeedController pu;


    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }

    // Update is called once per frame
    public void ResetBall()
    {
        //membuat kecepatan bola kembali seperti semula
        rb.velocity = new Vector2(Random.Range(1, resetPosition.x),resetPosition.y);
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
        Debug.Log(rb.velocity);
    }

    public void SpeedUp(float magnitude)
    {
        rb.velocity *= magnitude;
        Debug.Log(rb.velocity);
    }
}
