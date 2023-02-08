using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    [SerializeField]
    private float upperBound = 30f;
    [SerializeField]
    private float lowerBound = -30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            //Debug.Log("Game Over");
        }
        if (transform.position.x > 25)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -25f)
        {
            Destroy(gameObject);
            //Debug.Log("Game Over");
        }
    }
}
