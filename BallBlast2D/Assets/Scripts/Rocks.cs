using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks : MonoBehaviour
{
    [SerializeField]
    private int rockHealth = 2;
    public GameObject smallRocksL;
    public Rigidbody2D self;
    public GameObject smallRocksR;
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
            rockHealth--;
            Destroy(collision.gameObject);
            if(rockHealth <= 0)
            {
                Destroy(collision.gameObject);
                Instantiate(smallRocksL, transform.position, smallRocksL.transform.rotation);
                Instantiate(smallRocksR, transform.position, smallRocksR.transform.rotation);
                Destroy(this.gameObject);
            }
        }
    }
}
