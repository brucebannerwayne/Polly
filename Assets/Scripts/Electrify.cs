using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electrify : MonoBehaviour
{
    public GameObject ElectricOrb;
    public Transform tr;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Electric")
        {
            Invoke("SwitchOn", 0);
        }
    }
    public void SwitchOn()
    {
        Instantiate(ElectricOrb, tr.position, tr.rotation);
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
