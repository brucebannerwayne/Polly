using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraanim : MonoBehaviour
{
    public Animator a;
    public GameObject mipha;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
    }
   void Movee()
    {
        a.gameObject.GetComponent<Animator>().applyRootMotion = true;
        mipha.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
