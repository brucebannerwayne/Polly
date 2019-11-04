using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closestream : MonoBehaviour
{
    public GameObject stream;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag=="rock")
        {   
           stream.gameObject.GetComponent<BoxCollider2D>().enabled = false;
           // stream.gameObject.GetComponentInChildren<closestream>().enabled = false;
            stream.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        else
        {
            Debug.Log(1);
            stream.gameObject.GetComponent<BoxCollider2D>().enabled =true;
           // stream.gameObject.GetComponentInChildren<closestream>().enabled = true;
            stream.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        
    }
}
