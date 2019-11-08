using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//rise the anchor
public class CounterAnchor : MonoBehaviour
{
    public Vector2 CounterForce;
    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Anchor")
        {
            collision.gameObject.SendMessage("Down", CounterForce);
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
