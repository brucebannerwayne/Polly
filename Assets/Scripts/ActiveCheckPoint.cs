using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//checkpoint where player respawn from
public class ActiveCheckPoint : MonoBehaviour
{
    public Transform tr;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject.FindWithTag("GameManager").SendMessage("Checkpoint", tr);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
