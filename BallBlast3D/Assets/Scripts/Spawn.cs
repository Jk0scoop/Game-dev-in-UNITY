using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    PlayerController playerController;
    public GameObject Player1;
    public Rigidbody Player;
    public Rigidbody Ball;
    private float nextSpawn = 0.0f;
    public float ballSpawnRate = 2f;
    public float PowerUpRate = 10f;
    public float nextPowerUp = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerController = Player1.gameObject.GetComponent<PlayerController>();
        
        if (Time.time > nextSpawn)
        {
            ballSpawn();
        }
    }
    void ballSpawn()
    {
        nextSpawn = Time.time + ballSpawnRate;
        int xPos = Random.Range(-7,7);
        Instantiate(Ball, new Vector3(xPos, Random.Range(12,8), 0), Ball.transform.rotation);
    }
}
