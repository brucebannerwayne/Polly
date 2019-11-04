using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadStone : MonoBehaviour
{
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "obstacle")
        {
            
            GameObject.FindWithTag("Anchor").SendMessage("Drop");
            //子物体
            //禁止移动
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            collision.tag = "NoUse";
            
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
