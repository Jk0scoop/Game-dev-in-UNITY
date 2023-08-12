using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Vector3 startForce;
    public int ballHealth = 2;
    public Rigidbody smallBall;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(startForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag.Equals("Bullets"))
        {
            ballHealth--;
            if(ballHealth == 1)
            {
                Instantiate(smallBall, this.gameObject.transform.position, smallBall.transform.rotation);
                Instantiate(smallBall, this.gameObject.transform.position, smallBall.transform.rotation);

                Destroy(this.gameObject);
                Destroy(collision.gameObject);
            }
        }
    }
}
