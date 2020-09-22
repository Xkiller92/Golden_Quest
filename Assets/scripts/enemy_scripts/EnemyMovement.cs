using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform trans;
    Rigidbody2D rb;
    public float speed;
    public GameObject leftCheck;
    public GameObject rightCheck;
    float position = -1;
    public float health;
    public GameObject enemy;
    public GameObject rangeCheck;
    public float nextTime;
    public float cooldown;
    public GameObject player;
    public float damage;
    public float maxHealth;
    public GameObject healthBar; 
  

    // Start is called before the first frame update
    void Start()
    {
        GetComponents();
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        Death();
        EnemyCombat();
    }

    void FixedUpdate()
    {
        Movement();
    }

    void GetComponents()
    {
        trans = this.GetComponent<Transform>();
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Movement()
    {

        
        if (leftCheck.GetComponent<GroundCheck>().Leftgrounded == true && rightCheck.GetComponent<ReverseGroundCheck>().Rightgrounded == true)
        {
            position = +position;
        }
        else
        {
            position = -position;
        }

        Vector3 move = new Vector3(position, 0f, 0f);
        transform.position += move * Time.deltaTime * speed;

    }

    void Death()
    {
        if (health == 0)
        {
            enemy.SetActive(false);
        }
    }

    void EnemyCombat()
    {
        if (Time.time > nextTime)
        {
            if (rangeCheck.GetComponent<EnemyAttack>().inRange)
            {
                player.GetComponent<PlayerMovement>().health -= damage;
                nextTime = Time.time + cooldown;
            }
        }

    }
}
