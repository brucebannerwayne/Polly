using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script of trap which comes from underground
public class Trap : MonoBehaviour
{
    public Transform tr;
    public Vector2 getOut = Vector2.up;
    public Vector2 goBack = Vector2.down;
    public float speed;
    public void Attack()
    {
        tr.Translate(getOut.normalized * Time.deltaTime * speed, Space.World);
    }
    public void Retreat()
    {
        tr.Translate(goBack.normalized * Time.deltaTime * speed, Space.World);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.SendMessage("PlayerDead");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
