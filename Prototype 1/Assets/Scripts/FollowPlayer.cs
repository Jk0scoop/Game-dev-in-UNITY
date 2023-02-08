using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //GameObject is a type of varible which reference to game object present in the scene
    public GameObject player;
    //we can use offset as variable
    [SerializeField] //this line is used to present private variable in unity interface
    private Vector3 offset = new Vector3(0, 5.21f, -6.39f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called after Update of player object is called
    // LateUpdate will make camera movement smooth to follow vehicle
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        //prev line is same as next line. only diff is prev has public offset that can be changed in unity interface whereas next line does not
        //transform.position = player.transform.position + new Vector3(0, 5.21f, -6.39f); //temp vector3 is created using 'new' before 'Vector3( x, y, z)'
        
    }
}
