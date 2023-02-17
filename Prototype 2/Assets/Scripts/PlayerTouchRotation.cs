using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchRotation : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float rotateSpeed;
    bool leftIsTrue;
    bool rightIsTrue;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(leftIsTrue)
        {
            TurnLeft();
        }

        if(rightIsTrue)
        {
            TurnRight();
        }
    }

    public void pointerDownLeft()
    {
        leftIsTrue = true;
    }

    public void pointerUpLeft()
    {
        leftIsTrue = false;
    }

    public void pointerDownRight()
    {
        rightIsTrue = true;
    }

    public void pointerUpRight()
    {
        rightIsTrue = false;
    }

    public void TurnLeft()
    {
        transform.Rotate(new Vector3(0, -1, 0) * 360 * Time.deltaTime * rotateSpeed, Space.Self);
    }

    public void TurnRight()
    {
        transform.Rotate(new Vector3(0, 1, 0) * 360 * Time.deltaTime * rotateSpeed, Space.Self);
    }

    public void Attack()
    {
        Instantiate(projectilePrefab, this.gameObject.transform.position, this.gameObject.transform.rotation);
    }
}
