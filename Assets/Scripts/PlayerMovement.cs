using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  
    private Rigidbody2D rb;       

    private Vector2 movement;     

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {        
        GetInput();
        SetDirection();
    }

    void FixedUpdate()
    {        
        rb.velocity = movement * moveSpeed * Time.fixedDeltaTime;
    }    

    void GetInput(){
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    void SetDirection(){
        if (movement.x > 0){
            transform.localScale = Vector3.one;
        }
        else if (movement.x < 0){
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
