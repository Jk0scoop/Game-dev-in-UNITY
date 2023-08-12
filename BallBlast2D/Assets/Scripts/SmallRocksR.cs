using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallRocksR : MonoBehaviour
{
    public Rigidbody2D self;
    public Vector2 forceDir;
    // Start is called before the first frame update
    void Start()
    {
        self.AddForce(forceDir, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullets"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

}
