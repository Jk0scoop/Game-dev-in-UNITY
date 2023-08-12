using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.WorldToViewportPoint(Input.mousePosition);
            Debug.Log(touchPos);
            if(touchPos.x < 0)
            {
                rb.AddForce(Vector2.left * Speed * Time.deltaTime);
            }
            else if(touchPos.x >=0)
            { 
                rb.AddForce(Vector2.right * Speed * Time.deltaTime);
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
