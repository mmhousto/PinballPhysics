using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    private int isRand = 1;
    // Start is called before the first frame update
    void Start()
    {
        //get the value the player set last for randomness
        isRand = PlayerPrefs.GetInt("Rand", 1);
        var mat = GetComponent<CircleCollider2D>();

        //if is random is active pinball is given random friction and bounciness
        if (isRand == 1)
        {
            mat.sharedMaterial.friction = Random.Range(0.0f, 1f);
            mat.sharedMaterial.bounciness = Random.Range(0.5f, 1f);
            Debug.Log("Friction: " + mat.sharedMaterial.friction);
            Debug.Log("Bounciness: " + mat.sharedMaterial.bounciness);
        } else if (isRand == 0)
        {
            mat.sharedMaterial.friction = 0.6f;
            mat.sharedMaterial.bounciness = 1;
            Debug.Log("Default Friction: " + mat.sharedMaterial.friction);
            Debug.Log("Default Bounciness: " + mat.sharedMaterial.bounciness);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the value the player set last for randomness
        isRand = PlayerPrefs.GetInt("Rand", 1);

        //Destroys pinball
        if (Input.GetKey(KeyCode.R))
        {
            Destroy(gameObject);
        }

        //Toggles randomness
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (isRand == 1)
            {
                isRand = 0;
                PlayerPrefs.SetInt("Rand", isRand);
                Debug.Log("Randomness OFF");
            } else if (isRand == 0)
            {
                isRand = 1;
                PlayerPrefs.SetInt("Rand", isRand);
                Debug.Log("Randomness ON");
            }
            
            
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //gets the normal vector where it collided
        var normal = collision.contacts[0].normal;

        //flat bumper
        if (collision.collider.tag == "Bumper")
        {
            GetComponent<Rigidbody2D>().AddForce(normal * 2, ForceMode2D.Impulse);
        }

        //left circle bumper
        if (collision.collider.tag == "LBumper")
        {
            GetComponent<Rigidbody2D>().AddForce(normal * 2, ForceMode2D.Impulse);
        }

        //right circle bumper
        if (collision.collider.tag == "RBumper")
        {
            GetComponent<Rigidbody2D>().AddForce(normal * 4, ForceMode2D.Impulse);
        }

        //bottom wall
        if (collision.collider.tag == "Respawn")
        {
            Destroy(gameObject);
            SpawnManager.spawnBall();
        }

    }
}
