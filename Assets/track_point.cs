using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track_point : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pal")
        {
            if (this.gameObject.tag == "point0")
            {
                GameObject.Find("octopus 1").GetComponent<octopus_track>().point0 = 1;
                
            }
            if (this.gameObject.tag == "point1")
            {
                GameObject.Find("octopus 1").GetComponent<octopus_track>().point0 = 2;
            }

        }
    }
  
}
