using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    
    private Rigidbody2D rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput(){
        if(Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if(Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }else return Vector2.zero;
    }

    private void MoveObject(Vector2 movement){
        rb.velocity=movement;
    }
}
