using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electric : MonoBehaviour
{
    public void SelfDestroy()
    {
        
        GameObject.FindWithTag("Generator").SendMessage("SelfDestroy");
        GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().generatorNum = 1;
        Destroy(gameObject,2);
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
