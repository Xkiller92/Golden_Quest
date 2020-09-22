using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Transform trans;
    Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    public GameObject rangeCheck;
    public GameObject groundCheck;
    public float health;
    public float maxHealth;
    public Text playerHealth;



    void Start()
    {
        GetComponents();
        maxHealth = health;
    }

    private void Update()
    {
        
        HealthCheck();
        playerHealth.text = health.ToString();
    }

    void FixedUpdate()
    {
        Jump();
        if (Input.GetButton("Horizontal"))
        {
            Movement();

        }
    }

    void GetComponents()
    {
        rb = this.GetComponent<Rigidbody2D>();
        trans = this.GetComponent<Transform>();
    }

    void Movement()
    {
        Vector3 move = new Vector3 (Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += move * Time.deltaTime * speed;
    }

    void Jump()
    {        
            if (groundCheck.GetComponent<Grounded>().isGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse); 
            }       
    }

    

    void HealthCheck()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }


}
