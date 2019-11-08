using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//water level myst: pour water from A to C
public class SwitchAC : MonoBehaviour
{
    public GameObject target;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Electric")
        {
            
            target.SendMessage("AtoC");
            GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
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
