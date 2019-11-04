using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombexplo : MonoBehaviour
{
    public GameObject iron;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bomb")
        {
            //Debug.Log(232143);
            collision.gameObject.SendMessage("Explode");

            Invoke("beexplode", 3f);
        }
    }
    void beexplode()
    {
        if (this.tag == "LargeIron")
            Instantiate(iron, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.tag == "bomb")
    //    {
    //        Debug.Log(232143);
    //        collision.SendMessage("Explode");
    //        Destroy(gameObject, 5);
    //    }
    //}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
