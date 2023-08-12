using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Rigidbody bullet;
    public Rigidbody Player;
    public Rigidbody Ball;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
    private float nextSpawn = 0.0f;
    public float ballSpawnRate = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {
            fire();
        }
        if (Time.time > nextSpawn)
        {
            ballSpawn();
        }
    }
    void fire()
    {
        nextFire = Time.time + fireRate;
        Instantiate(bullet, Player.transform.position + new Vector3(0, 1, 0), bullet.transform.rotation);
        
    }

    void ballSpawn()
    {
        nextSpawn = Time.time + ballSpawnRate;
        int xPos = Random.Range(-8,8);
        Instantiate(Ball, new Vector3(-xPos, 4, 0), Ball.transform.rotation);
    }
    
}
