using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricDoor : MonoBehaviour
{
    public Sprite sprite1;
    
    public bool canOpen = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "EleOrb")//when the door coilides with electric orb, open it
        {
            Debug.Log("Change state");
            canOpen = true;
            collision.gameObject.SendMessage("SelfDestruction");
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
        }
    }

    public void Open()
    {
        if (canOpen == true)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
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
