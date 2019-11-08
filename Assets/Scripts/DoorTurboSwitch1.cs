using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTurboSwitch1 : MonoBehaviour
{
    public Vector2 DownForce = Vector2.down;
    public float speed;
    public GameObject Air;
    public GameObject anotherSwitch;
    public GameObject turbo;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Electric")//if electric door's lock contacts with Electric Ray's electric, open the door
        {
            Debug.Log("move");
            DownForce = Vector2.down;
            DownForce *= speed;
            Air.SendMessage("Move", DownForce);
            turbo.SendMessage("SwitchOn");
            Invoke("Change", 2);
            Destroy(gameObject, 2);
        }
    }
    public void Change()
    {
        Instantiate(anotherSwitch, transform.position, transform.rotation);
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
