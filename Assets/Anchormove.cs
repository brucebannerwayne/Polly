using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//move anchor
public class Anchormove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="rock"||collision.tag=="Iron")
        {
            //Debug.Log(2);
            collision.transform.parent = gameObject.transform;
            collision.GetComponent<Rigidbody2D>().bodyType= RigidbodyType2D.Static;
            GameObject.FindWithTag("Anchor").SendMessage("Drop");
            collision.tag = "NoUse";

        }
    }
}
