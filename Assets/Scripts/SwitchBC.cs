using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBC : MonoBehaviour
{
    public GameObject target;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Electric")
        {
            target.SendMessage("BtoC");
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
