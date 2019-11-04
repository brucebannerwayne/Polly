using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAir : MonoBehaviour
{
    public Vector2 UpForce = Vector2.up;
    public Vector2 DownForce = Vector2.down;
    public float speed;
    public GameObject Air;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            DownForce = Vector2.down;
            DownForce *= speed;
            Air.SendMessage("Move", DownForce);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            UpForce = -DownForce;
            Air.SendMessage("Move", UpForce);
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
