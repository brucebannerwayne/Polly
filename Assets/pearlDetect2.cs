using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pearlDetect2 : MonoBehaviour
{
    public GameObject tr;
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Peral")
        {
            tr.SendMessage("Close");
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
