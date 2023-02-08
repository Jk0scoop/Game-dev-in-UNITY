using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float sidewaysSpeed = 10f;
    public float xRange = 10;
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

        //Box limit
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-xRange,xRange), transform.position.y, Mathf.Clamp(transform.position.z, 0, 15));

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //sideways input
        transform.Translate(Vector3.right * Time.deltaTime * sidewaysSpeed * horizontalInput);
        //vertical input
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * sidewaysSpeed * verticalInput);

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

    }
}
