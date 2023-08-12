using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Material[] materials;
    public Vector3 startForce;
    public int ballHealth = 2;
    public Rigidbody smallBallRight;
    public Rigidbody smallBallLeft;
    public Renderer r;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(startForce, ForceMode.Impulse);
        r = GetComponent<Renderer>();
        r.enabled = true;
        r.sharedMaterial = materials[0];
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
            r.sharedMaterial = materials[1];
            this.transform.localScale = new Vector3(2.25f, 2.25f, 2.25f);
            if (ballHealth == 1)
            {
                Instantiate(smallBallRight, this.gameObject.transform.position, smallBallRight.transform.rotation);
                Instantiate(smallBallLeft, this.gameObject.transform.position, smallBallLeft.transform.rotation);
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
            }
            Destroy(collision.gameObject);
        }
    }
}
