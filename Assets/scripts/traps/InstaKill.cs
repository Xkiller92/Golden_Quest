using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstaKill : MonoBehaviour
{
    // if you apply this to an object its must have a collider2D in order for this to work
    public GameObject player;
    public GameObject healthBar;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        player.GetComponent<PlayerMovement>().health = 0;
    }

}
