using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    public Transform trans; 
    public LayerMask ground;
    public float radious;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(trans.position, radious, ground);  
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(trans.position, radious);
    }
}
