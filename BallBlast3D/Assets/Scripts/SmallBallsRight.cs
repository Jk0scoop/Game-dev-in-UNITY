using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBallsRight : MonoBehaviour
{
    public Vector3 startForceSmall;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(startForceSmall, ForceMode.Impulse);
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
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
