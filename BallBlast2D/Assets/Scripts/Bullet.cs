using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-1,0) * Time.deltaTime * bulletSpeed);
        DestroyOutOfBound();
    }

    void DestroyOutOfBound()
    {
        if(transform.position.y >= 5.3f)
        {
            Destroy(this.gameObject);
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag.Equals("Rocks"))
    //    {
    //        Destroy(collision.gameObject);
    //        Destroy(this.gameObject);
    //    }
    //}
}
