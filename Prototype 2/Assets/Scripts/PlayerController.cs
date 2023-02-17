using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float sidewaysSpeed = 10f;
    public float xRange = 10;
    public Joystick joystick;
    public bool IsKeyboard = true;
    public bool IsTouch = false;
    //public float rotateRate = 50f;

    //public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x < -xRange)
        //{
        //    transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        //}
        //if (transform.position.x > xRange)
        //{
        //    transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        //}



        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    //instantiate pizza
        //    Instantiate(projectilePrefab, this.gameObject.transform.position, this.gameObject.transform.rotation);
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Rotate(0, -1 * rotateRate, 0, Space.Self);
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Rotate(0, 1 * rotateRate, 0, Space.Self);
        //}
        keyboardControl(IsKeyboard);
        touchControl(IsTouch);

    }

    void keyboardControl(bool x)
    {
        if(x)
        {
            //Box limit
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xRange, xRange), transform.position.y, Mathf.Clamp(transform.position.z, 0, 15));

            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            //sideways input
            transform.Translate(Vector3.right * Time.deltaTime * sidewaysSpeed * horizontalInput);
            //vertical input
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * sidewaysSpeed * verticalInput);
        }
        else if(!x)
        {

        }
    }

    void touchControl (bool x)
    {
        if(x)
        {
            //Box limit
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xRange, xRange), transform.position.y, Mathf.Clamp(transform.position.z, 0, 15));
            if(joystick.Horizontal >= .2f)
            {
                horizontalInput = 1;
            }
            else if(joystick.Horizontal <= -.2f)
            {
                horizontalInput = -1;
            }
            else
            {
                horizontalInput = 0;
            }

            if (joystick.Vertical >= .2f)
            {
                verticalInput = 1;
            }
            else if (joystick.Vertical <= -.2f)
            {
                 verticalInput = -1;
            }
            else
            {
                verticalInput = 0;
            }

            //sideways input
            transform.Translate(Vector3.right * Time.deltaTime * sidewaysSpeed * horizontalInput);
            //vertical input
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * sidewaysSpeed * verticalInput);


        }
        else if(!x)
        {

        }
    }
}
