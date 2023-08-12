using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{
    public GameObject[] powersUps;
    public float PowerUpRate = 10f;
    public float nextPowerUp = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextPowerUp)
        {
            PowerUpsSpawn(0);
        }
    }


    void PowerUpsSpawn(int powIndex)
    {
        nextPowerUp = Time.time + PowerUpRate;
        int xPos = Random.Range(-7, 7);
        Instantiate(powersUps[0], new Vector3(xPos, Random.Range(12, 8), 0), powersUps[0].transform.rotation);
    }
}
