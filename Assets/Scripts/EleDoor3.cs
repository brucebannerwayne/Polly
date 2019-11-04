using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EleDoor3 : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public bool canOpen = false;
    public bool Key1 = false;
    public bool Key2 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Key1 == true && Key2 == true)
        {
            
            canOpen = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
        }
        else
        {

            canOpen = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
        }
    }
    public void Open()
    {
        if(canOpen == true)
        {
            Destroy(gameObject.GetComponent<BoxCollider2D>());
        }
    }
}
