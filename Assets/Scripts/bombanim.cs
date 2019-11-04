using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombanim : MonoBehaviour
{
    public Animator anim;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        anim.GetComponent<Animator>();
        if (this.gameObject.GetComponent<Bomb>().isshoot==false)
        {
            anim.SetBool("iscollision", true);
        }
    }
}
