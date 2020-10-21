using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject pinball;
    private static GameObject temp;
    private static Vector3 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = transform.position;
        temp = pinball;
        spawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void spawnBall()
    {
        Instantiate(temp, spawnPos, Quaternion.identity);
    }
}
