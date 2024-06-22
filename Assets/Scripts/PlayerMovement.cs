using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float hI;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hI = Input.GetAxis("Horizontal");
        move();
    }

    void move()
    {
        rb.velocity = new Vector3(hI * 13f, 0f, 0f);
        
    }
}
