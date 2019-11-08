using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//script used to active pal's usage
public class ActiveFriend : MonoBehaviour
{
    public GameObject friends;
    public Image ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Joystick1Button1))
            ui.GetComponent<CanvasGroup>().alpha = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            //Debug.Log(11);
            friends.gameObject.GetComponent<GroupBehaviour>().enabled = true;
            friends.gameObject.GetComponent<spriteflip>().enabled = true;
            friends.gameObject.GetComponent<Animator>().applyRootMotion = true;
            this.GetComponent<AudioSource>().Play();
            this.GetComponent<BoxCollider2D>().enabled = false;
            ui.GetComponent<CanvasGroup>().alpha = 1;
        }
    }
}
