using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float sidewaysSpeed = 5;
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        //if(Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * sidewaysSpeed);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * sidewaysSpeed);
        //}


        transform.Translate(new Vector3(1, 0, 0) * Horizontal * Time.deltaTime * sidewaysSpeed);

        //if (Input.GetKey(KeyCode.D))
        //{
        //    rb.AddForce(new Vector3(1, 0, 0) * sidewaysSpeed * Time.deltaTime, ForceMode.Force);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    rb.AddForce(new Vector3(-1, 0, 0) * sidewaysSpeed * Time.deltaTime, ForceMode.Force);
        //}
    }
}
