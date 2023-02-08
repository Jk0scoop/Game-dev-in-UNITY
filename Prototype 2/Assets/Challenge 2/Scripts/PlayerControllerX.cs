using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //i fu want to set spawnIntervalTime >100 than spawnLastTime must be |spawnIntervalTime| <= |spawnLastTime|
    private float spawnLastTime = -100.0f;  //its a number which is always less than real time
    [SerializeField]
    private float spawnIntervalTime = 5.0f;  //its a time interval b/w spawn

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //in below line |spawnLastTime| >= |spawnIntervaTime|
            if (Time.time > spawnLastTime + spawnIntervalTime)//'Time.time' is a keyword for real time
            {

                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                spawnLastTime = Time.time;
            }//if time is spawnEnabled

        }//key SPACE press
    }

}
