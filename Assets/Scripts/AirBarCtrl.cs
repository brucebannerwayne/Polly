using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirBarCtrl : MonoBehaviour
{
    public GameObject tr;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Circuit")
        {
            tr.SendMessage("SwitchOn");
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Circuit")
        {
            tr.SendMessage("SwitchOff");
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
