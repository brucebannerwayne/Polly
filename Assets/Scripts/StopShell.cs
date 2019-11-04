using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopShell : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Shellup")
        {
            Debug.Log("1");
            collision.GetComponent<CloseShell>().canRotate = false;
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
