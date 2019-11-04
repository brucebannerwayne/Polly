using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeSuck : MonoBehaviour
{
    public float speed;
    public void GetSuck(Vector3 dir)
    {
        transform.Translate(dir.normalized * Time.deltaTime * speed);
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
