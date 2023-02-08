using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public int life = 5;
    [SerializeField]
    private GameObject spawnFalse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Animal")
        {
            life--;
            Debug.Log("Lifes left : " + life);
            if (life == 0)
            {
                Debug.Log("Game Over");
                Destroy(this.gameObject);
                Destroy(spawnFalse);
            }
        }
    }
}
