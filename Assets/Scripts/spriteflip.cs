using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteflip : MonoBehaviour
{
    private bool isright = true;

    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (h < 0)
        {
            if (isright)
            {
                Flip();
                isright = false;
            }
        }
        if (h > 0)
        {
           
            if (!isright)
            {
                Flip();
                isright = true;
            }
        }

    }
}
