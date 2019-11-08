using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//open electric door
public class EleDoorType : MonoBehaviour
{
    public Sprite sprite1;
    public bool canOpen = false;
    public void Open()
    {
        if(canOpen == true)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
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
