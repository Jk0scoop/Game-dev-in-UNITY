using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabDown;
    public GameObject[] animalPrefabLeftRight;
    public GameObject[] animalPrefabRightLeft;
    //public bool toggleToKeyDown;
    [SerializeField]
    private float spawnRangeX = 20;
    [SerializeField]
    private float spawnPosZ = 20;
    [SerializeField]
    private float startDelay = 5.0f;
    [SerializeField]
    private float spawnInterval = 1.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    SpawnRandomAnimal();
        //}

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabDown.Length);
        Vector3 spawnPosDown = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabDown[animalIndex], spawnPosDown, animalPrefabDown[animalIndex].transform.rotation);
        Vector3 spawnPosLeft = new Vector3(-23, 0, Random.Range(0, 15));
        Instantiate(animalPrefabLeftRight[animalIndex], spawnPosLeft, animalPrefabLeftRight[animalIndex].transform.rotation);
        Vector3 spawnPosRight = new Vector3(23, 0, Random.Range(0, 15));
        Instantiate(animalPrefabRightLeft[animalIndex], spawnPosRight, animalPrefabRightLeft[animalIndex].transform.rotation);

    }











    //void toggle(bool x)
    //{
    //    if (x)
    //    {
    //        int animalIndex = Random.Range(0, animalPrefab.Length/*array length*/);
    //        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
    //        if (Input.GetKeyDown(KeyCode.S))
    //        {
    //            Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
    //        }
    //    }
    //    else if (!x)
    //    {
    //        int animalIndex = Random.Range(0, animalPrefab.Length/*array length*/);
    //        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
    //        if (Input.GetKey(KeyCode.S))
    //        {
    //            Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
    //        }
    //    }
    //}
}
