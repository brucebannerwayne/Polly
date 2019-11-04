using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCtrl : MonoBehaviour
{
    public GameObject tr;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Iron")
        {
            tr.GetComponent<EleDoorType>().canOpen = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Iron")
        {
            tr.GetComponent<EleDoorType>().canOpen = false;
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
