using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    
    
    public float bulletSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //for (var i = 0; i < 10; i++)
        //{
        //    Instantiate(bullet, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * bulletSpeed);
        //Instantiate(bullet, new Vector3(0,0,0) * Time.deltaTime, Quaternion.identity);
        DestroyOutofBound();

        
    }

    void DestroyOutofBound()
    {
        if(transform.position.y >= 7f)
        {
            Destroy(this.gameObject);
        }
    }

    
}
