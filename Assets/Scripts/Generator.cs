using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public Transform target;
    public GameObject electric;

    void Flip()//发射方向
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
    public void SetOff()
    {
        Instantiate(electric, target.position, target.rotation);
        GameObject.FindWithTag("Electric").SendMessage("SelfDestroy");
        if (GameObject.FindWithTag("Player").gameObject.GetComponent<PlayerMovement>().isright == false)
        {
            Flip();
        }
    }
    public void SelfDestroy()
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Flip();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
