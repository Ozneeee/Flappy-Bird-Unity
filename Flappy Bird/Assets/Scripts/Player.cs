using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    void Start()  //Void start
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() // Void update
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)|| Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }   
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        gameManager.GameOver();
    }

}
