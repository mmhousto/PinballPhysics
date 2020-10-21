using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = -transform.right * 2;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //sends platform to the right when collides with left wall
        if (collision.collider.tag == "WallL")
        {
            var rb = GetComponent<Rigidbody2D>();
            rb.velocity = transform.right * 2;
        }
        //sends platform to the left when collides with right wall
        if (collision.collider.tag == "WallR")
        {
            var rb = GetComponent<Rigidbody2D>();
            rb.velocity = -transform.right * 2;
        }
    }
}
