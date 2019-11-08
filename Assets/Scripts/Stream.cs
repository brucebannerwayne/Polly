using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script of stream
public class Stream : MonoBehaviour
{
    public Vector2 streamForce;
    public float streamStrength;
    public float speed;
   
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            
            streamForce = streamForce.normalized * streamStrength;
            
            collision.SendMessage("StreamEffect", streamForce);
        }
    }
    public void Move(Vector3 dir)
    {
        transform.position = Vector3.MoveTowards(transform.position, dir,Time.deltaTime*speed);
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
