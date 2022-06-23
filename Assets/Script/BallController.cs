using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector2 speed;
    public Vector2 resetPosition;
    private PUSpeedController pu;
    public string lastCollision,state;

    public bool nama;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }

    // Update is called once per frame
    public void ResetBall()
    {
        int newspeedx =Random.Range(1, (int)speed.x) ;
        //membuat kecepatan bola kembali seperti semula
        rb.velocity = new Vector2(newspeedx,2);
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
        Debug.Log(rb.velocity);
    }

    public void SpeedUp(float magnitude)
    {
        rb.velocity *= magnitude;
        Debug.Log(rb.velocity);
    }

    private void OnCollisionEnter2D(Collision2D collisioninfo) {
        string lastCollision = collisioninfo.collider.tag;
        if(lastCollision=="Paddle"){
            if(collisioninfo.collider.name=="Kanan"){
                nama=true;
            }else{
                nama=false;
            }
        }
    }
}
