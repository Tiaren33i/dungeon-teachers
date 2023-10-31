using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : parametor
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private Vector2 moveVector;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move();
    }
    private void move()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveVector.x * moveSpeed, moveVector.y * moveSpeed);

    }
}
