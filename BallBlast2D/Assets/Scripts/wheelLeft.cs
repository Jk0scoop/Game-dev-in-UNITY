using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelLeft : MonoBehaviour
{
    [SerializeField]
    private float HInput;
    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HInput = Input.GetAxis("Horizontal");
        if(HInput > 0)
        {
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * HInput * RotationSpeed,Space.Self);
        }
        else if(HInput < 0)
        {
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * HInput * RotationSpeed, Space.Self);
        }
    }
}
