using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerManager : MonoBehaviour
{
    public GameObject anchor;
    float speed = 6;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(anchor.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        //pulls plunger
        if(Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 dir = -transform.up * speed;
            GetComponent<Rigidbody2D>().velocity = dir;
        }
        
    }
}
