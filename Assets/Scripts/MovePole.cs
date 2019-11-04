using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePole : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Air")
        {
            collision.gameObject.GetComponent<AirMovement>().move = Vector2.zero;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
