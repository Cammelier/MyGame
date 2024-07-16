using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class player : MonoBehaviour
{
    public Boolean isDead;
    public float jumpForce = 4f;
    Rigidbody2D rb;
    Animator anim;

    public GameObject retryButton, inGameScore;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            playerJump();
        }
        else
        {
            anim.SetTrigger("Death");
            gameManager.instance.DisplayDeathPanel();
        }

    }

    public void playerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = jumpForce * Vector2.up;
        }
    }

    void destroyPlayer()
    {
        Destroy(gameObject);
        inGameScore.SetActive(false);   
        retryButton.SetActive(true);   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        Time.timeScale = 0;
    }
}