using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool touchControl = false;
    public bool KeyboardControl= true;
    public float sidewaysSpeed = 5;
    public Rigidbody rb;
    public bool isFire = true;
    public bool isDoubleFire = false;
    public bool isTripleFire = false;
    private float nextFire = 0.0f;
    public float fireRate = 0.5f;
    public Rigidbody bullet;
    public int powerUpDetected = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -14, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (KeyboardControl == true)
        {
            KeyBoard();
        }
        if (touchControl == true)
        {
            touch();
        }
        
        //if(Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * sidewaysSpeed);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * sidewaysSpeed);
        //}
        //bound area
        

        //if (Input.GetKey(KeyCode.D))
        //{
        //    rb.AddForce(new Vector3(1, 0, 0) * sidewaysSpeed * Time.deltaTime, ForceMode.Force);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    rb.AddForce(new Vector3(-1, 0, 0) * sidewaysSpeed * Time.deltaTime, ForceMode.Force);
        //}
        if (Time.time > nextFire && isFire == true)
        {
            fire();
        }
        if (Time.time > nextFire && isDoubleFire == true)
        {
            doubleFire();
        }
        if (Time.time > nextFire && isTripleFire == true)
        {
            tripleFire();
        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("PowerUps"))
        {
            powerUpDetected++;
            isFire = false;
            isDoubleFire = true;
            if(isFire == false && isDoubleFire == true && powerUpDetected >= 2)
            {
                isDoubleFire = false;
                isTripleFire = true;
            }
            Destroy(collision.gameObject);
        }
    }


    void tripleFire()
    {
        nextFire = Time.time + fireRate;
        Instantiate(bullet, this.transform.position + new Vector3(0.5f, 1, 0), bullet.transform.rotation);
        Instantiate(bullet, this.transform.position + new Vector3(-0.5f, 1, 0), bullet.transform.rotation);
        Instantiate(bullet, this.transform.position + new Vector3(0, 1, 0), bullet.transform.rotation);
    }
    void doubleFire()
    {
        nextFire = Time.time + fireRate;
        Instantiate(bullet, this.transform.position + new Vector3(0.4f, 1, 0), bullet.transform.rotation);
        Instantiate(bullet, this.transform.position + new Vector3(-0.4f, 1, 0), bullet.transform.rotation);

    }
    void fire()
    {
        nextFire = Time.time + fireRate;
        Instantiate(bullet, this.transform.position + new Vector3(0, 1, 0), bullet.transform.rotation);

    }

    void KeyBoard()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.35f, 7.35f), transform.position.y, transform.position.z);
        transform.Translate(new Vector3(1, 0, 0) * Horizontal * Time.deltaTime * sidewaysSpeed);
    }

    void touch()
    {
        if (Input.GetMouseButton(0))
        {
            float Horizontal = Input.GetAxis("Horizontal");
            float Vertical = Input.GetAxis("Vertical");
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(touchPos);
            if(touchPos.x < 0)
            {
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, touchPos.x, touchPos.x), transform.position.y, 0);
                rb.AddForce(new Vector3(-1, 0, 0) * sidewaysSpeed, ForceMode.Force);
            }
            if (touchPos.x > 0)
            {
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, touchPos.x, touchPos.x), transform.position.y, 0);
                rb.AddForce(new Vector3(1, 0, 0) * sidewaysSpeed, ForceMode.Force);
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
