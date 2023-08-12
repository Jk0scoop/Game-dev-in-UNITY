using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 2;
    Rigidbody2D rb;
    private float HInput;
    public float HBounds;
    public GameObject bullet;
    public bool isFire = true;
    private float nextFire = 0.0f;
    public float fireRate = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(0, -4.5f, 0);
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        HInput = Input.GetAxis("Horizontal");
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -HBounds, HBounds), -4);
        //if (Input.GetMouseButton(0))
        //{
        //    Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    Debug.Log(touchPos);
        //}
        //else
        //{
        //    rb.velocity = Vector2.zero;
        //}
        moveRight();

        if (Time.time > nextFire && isFire == true && Input.GetKey(KeyCode.Space))
        {
            fire();
        }

    }

    void moveRight()
    {
        transform.Translate(Vector2.right * HInput * Time.deltaTime * Speed);
    }

    void fire()
    {
        nextFire = Time.time + fireRate;
        Instantiate(bullet, this.transform.position + new Vector3(0, 0.9f, 0), bullet.transform.rotation);
    }
}
