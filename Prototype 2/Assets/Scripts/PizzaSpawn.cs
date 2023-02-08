using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaSpawn : MonoBehaviour
{
    public GameObject player;
    public GameObject pizza;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //instantiate pizza
            Instantiate(pizza, player.transform.position, player.transform.rotation);
        }

        transform.Translate(0, 0, 1, Space.Self);
    }
}
