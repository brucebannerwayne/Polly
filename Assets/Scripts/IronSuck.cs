using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//make iron object move towards magnet
public class IronSuck : MonoBehaviour
{
    public void GetSuck(Vector2 SuckForce)
    {
        transform.Translate(SuckForce * Time.deltaTime,Space.World);
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
