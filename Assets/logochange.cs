using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logochange : MonoBehaviour
{
    private float timer=-1.5f;
    private float timer2 = 1;
    //float DURATION = 2.5f;
    void Start()
    {
        this.GetComponent<CanvasGroup>().alpha = timer;

    }
    // Update is called once per frame
    void Update()
    {
        
        timer += 0.01f;
        if(timer>0)
        {
            this.GetComponent<CanvasGroup>().alpha = timer;
            Debug.Log(timer);
            if ((timer > 2))
            {
                timer2 -= 0.01f;
                this.GetComponent<CanvasGroup>().alpha = timer2;
                if (timer2 <= 0)
                    this.gameObject.SetActive(false);
            }
        }
      
           
    }

 

    
}
