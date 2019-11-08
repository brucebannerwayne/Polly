using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//close the shell if it collides with the peral
public class PearlDetect : MonoBehaviour
{
    public GameObject tr;
    public void OnTriggerEnter2D(Collider2D collision)
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
