using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricDoorOpen : MonoBehaviour
{
    public GameObject tr;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            tr.SendMessage("Open");
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
