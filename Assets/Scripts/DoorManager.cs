using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//script used to load next scene when player entered the certain door
public class DoorManager : MonoBehaviour
{
    private Animator Door;
    public Animator Key;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            Key.SetTrigger("haha");
            Door.SetTrigger("isOpen");

           Invoke("Scene", 2f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

        Door = gameObject.GetComponent<Animator>();
        Key=Key.gameObject.GetComponent<Animator>();
    }

    void Scene()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
}
