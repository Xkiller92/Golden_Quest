using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseGroundCheck : MonoBehaviour
{
    GameObject check;
    public LayerMask ground;
    public bool Rightgrounded;
    public Transform trans;
    public float radious;
    // Start is called before the first frame update
    void Start()
    {
        GetComponents();
    }

    // Update is called once per frame
    void Update()
    {
        GetGround();
    }

    void GetComponents()
    {
        check = this.GetComponent<GameObject>();
    }

    void GetGround()
    {
        Rightgrounded = Physics2D.OverlapCircle(trans.position, radious, ground);
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(trans.position, radious);
    }
}
