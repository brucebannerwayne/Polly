using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDetection : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            gameObject.GetComponentInParent<Trap>().SendMessage("Attack");
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            gameObject.GetComponentInParent<Trap>().SendMessage("Retreat");
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
