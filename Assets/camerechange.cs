using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerechange : MonoBehaviour
{
    public float a;
    public float b;
    public float c;
    public float d;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().minPosx=a;
        GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().minPosy=b;
       GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().maxPosx=c;
         GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().maxPosy=d;
        this.gameObject.GetComponent<BoxCollider2D>().enabled=false;
    }
}
