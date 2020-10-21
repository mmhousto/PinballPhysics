using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject leftPaddle, rightPaddle;
    private float speed = 50f;
    private float slowSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //left paddle
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            leftPaddle.GetComponent<Rigidbody2D>().velocity = transform.up * speed;
        }

        //right paddle
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightPaddle.GetComponent<Rigidbody2D>().velocity = transform.up * slowSpeed;
        }

        //spawns ball when 'r' is keyed
        if (Input.GetKey(KeyCode.R))
        {
            SpawnManager.spawnBall();
        }
    }
}
