using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(new Vector3(0, -1, 0) * 360 *  Time.deltaTime * rotateSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(new Vector3(0, 1, 0) * 360* Time.deltaTime * rotateSpeed, Space.Self);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //instantiate pizza
            Instantiate(projectilePrefab, this.gameObject.transform.position, this.gameObject.transform.rotation);
        }
    }
}
