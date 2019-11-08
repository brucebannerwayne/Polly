using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Electric door control
public class EleDoor2 : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public bool canOpen = false;
    public void SwitchOn()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        canOpen = true;
        
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
    }
    public void SwitchOff()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        canOpen = false;
        
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
    }
    public void Open()
    {
        if (canOpen == true)
        {
            Destroy(gameObject.GetComponent<BoxCollider2D>());
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
