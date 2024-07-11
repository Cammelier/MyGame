using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class player : MonoBehaviour
{
    public float jumpForce = 4f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerJump();
    }

    public void playerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = jumpForce * Vector2.up;
        }
    }
}
