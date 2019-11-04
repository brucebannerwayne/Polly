using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbo : MonoBehaviour
{
    public Transform tr;
    public Transform tr2;
    public GameObject stream;
    public bool canKill = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (canKill == true)
            {
                collision.SendMessage("PlayerDead");
            }
        }
    }
    public void SwitchOn()
    {
        stream.SendMessage("Move", tr.position);
        canKill = true;
        
    }
    public void SwitchOff()
    {
        canKill = false;
        stream.SendMessage("Move", tr2.position);
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
