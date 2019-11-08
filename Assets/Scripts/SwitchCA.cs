using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//water level myst: pour water from C to A
public class SwitchCA : MonoBehaviour
{
    public GameObject target;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Electric")
        {
            target.SendMessage("CtoA");
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
