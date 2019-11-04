using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorDown : MonoBehaviour
{
    public Animator a;
    public int anchorfall=0;
    public void Drop()
    {
        anchorfall += 1;
        a.SetInteger("anchorfall", anchorfall);
        if (anchorfall > 4)
        {
            for (int i = 0; i < transform.childCount; i++)
                Destroy(transform.GetChild(i).gameObject);
        }
        GameObject.Find("GameManager").GetComponent<LoadScene3>().enabled = true;
        GameObject.Find("GameManager").GetComponent<AudioSource>().Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        a=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
