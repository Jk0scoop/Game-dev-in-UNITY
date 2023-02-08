using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    private float turnSpeed = 0f;
    private float sidewaysInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //next two lines are giving input to player
        sidewaysInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //We'll move the vehicle forward
        //next line will translate vehicle at 60m per second as update is called 60m per second
        //transform.Translate(0, 0, 1f);
        //next line is same as prev line
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);
        //prev line moves forward and backward
        //next line rotates vehicles sideways
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * sidewaysInput);


        //next line will send message to other object
        //transform.SendMessage("Hello");
        //next line will rotate object in any direction
        //transform.Rotate(0, 0, 20f * Time.deltaTime);
    }
}
