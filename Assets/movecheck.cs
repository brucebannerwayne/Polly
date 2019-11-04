using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecheck : MonoBehaviour
{
    public Transform check;
    public float minx;
    public float maxx;
    public float miny;
    public float maxy;
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
        if(collision.tag=="Player")
        {
            collision.transform.position = check.transform.position;
            GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().minPosx = minx;
            GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().minPosy = miny;
            GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().maxPosx = maxx;
            GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().maxPosy = maxy;

        }
    }
}
