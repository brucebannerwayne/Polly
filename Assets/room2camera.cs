using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room2camera : MonoBehaviour
{
    public Animator a;
    public Animator fish;
    public Animator explode;
    public Animator stone;
    // Start is called before the first frame update
    void Start()
    {
        a = a.gameObject.GetComponent<Animator>();
        fish=fish.gameObject.GetComponent<Animator>();
        //stone = stone.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject.Find("Main Camera").gameObject.GetComponent<Animator>().enabled = true;
            GameObject.Find("Mipha").gameObject.GetComponent<PlayerMovement>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            //关闭各种脚本和速度
            GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().enabled = false;
            a.SetTrigger("isRoom3");
            fish.SetTrigger("isRoom3");
            //stone.SetTrigger("isRoom3");
            Invoke("OpenPlayer", 4f);

        }
    }

    void OpenPlayer()
    {
        GameObject.Find("Mipha").gameObject.GetComponent<PlayerMovement>().enabled = true;
        GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().enabled = true;
        GameObject.Find("Main Camera").gameObject.GetComponent<Animator>().enabled = false;
        GameObject.Find("fallwall").gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}
