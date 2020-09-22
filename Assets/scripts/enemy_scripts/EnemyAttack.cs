using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Transform playerPos;
    public float radious;
    public bool inRange;
    public LayerMask player;

    // Update is called once per frame
    void Update()
    {
        inRange = Physics2D.OverlapCircle(playerPos.position, radious, player);
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(playerPos.position, radious); 
    }

}
