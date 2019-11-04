using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterConduct : MonoBehaviour
{
    public int conduct;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Circuit")
        {
            collision.GetComponent<Resistance>().ohm = conduct;
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
