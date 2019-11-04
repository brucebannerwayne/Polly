using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCamera : MonoBehaviour
{
    public Animator a;
    public Animator stone;
    // Start is called before the first frame update
    void Start()
    {
        a = a.gameObject.GetComponent<Animator>();
       stone = stone.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            GameObject.Find("Main Camera").gameObject.GetComponent<Animator>().enabled = true;
            GameObject.Find("Mipha").gameObject.GetComponent<PlayerMovement>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            //关闭各种脚本和速度
            GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().enabled = false;
            a.SetTrigger("isRoom2");
           stone.SetTrigger("isRoom2");
            Invoke("OpenPlayer", 4f);
           
        }
       
       
    }
    void OpenPlayer()
    {
        GameObject.Find("Mipha").gameObject.GetComponent<PlayerMovement>().enabled = true;
        GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().enabled = true;
        GameObject.Find("Main Camera").gameObject.GetComponent<Animator>().enabled = false;
    }
}
