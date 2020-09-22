using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : MonoBehaviour
{
    public bool inRange;
    public Transform trans;
    public float radiuos;
    public LayerMask enemy;
    public float damage;
    public int i = 0;
    public GameObject health;


    void Start()
    {

    }


    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Kill();
        }
    }



    void Kill()
    {
        Collider2D[] inRange = Physics2D.OverlapCircleAll(transform.position, radiuos, enemy);
        foreach (Collider2D enemy in inRange)
        {
            enemy.GetComponent<EnemyMovement>().health -= damage;
            i++;
            health.GetComponent<HealthDisplay>().DisplayBar();
        }
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(trans.position, radiuos);
    }
}

