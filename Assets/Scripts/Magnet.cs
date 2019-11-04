using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public float SuckDistance;
    public List<GameObject> SuckObject = new List<GameObject>();
    public float SuckForce;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Electric")
        {
            SwitchOn();
        }
    }
    public void SwitchOn()
    {
        SuckObject.Clear();
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, SuckDistance);
        foreach(Collider2D c in colliders)
        {
            if(c.tag =="Iron" || c.tag == "LargeIron")
            {
                SuckObject.Add(c.gameObject);
            }
        }
        foreach(GameObject G in SuckObject)
        {
            Vector3 Dir = transform.position - G.transform.position;
            Dir *= SuckForce;
            G.SendMessage("GetSuck", Dir);
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
