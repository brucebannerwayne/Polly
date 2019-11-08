using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTurboSwitch2 : MonoBehaviour
{
    public Vector2 UpForce = Vector2.up;
    public float speed;
    public GameObject Air;
    public GameObject anotherSwitch;
    public GameObject turbo;
    public void OnTriggerEnter2D(Collider2D collision)//control another kind of electric door
    {
        if (collision.tag == "Electric")
        {
            Debug.Log("CanSwitch");
            UpForce = Vector2.up;
            UpForce *= speed;
            Air.SendMessage("Move", UpForce);
            turbo.SendMessage("SwitchOff");
            Invoke("Change", 2);
            Destroy(gameObject,2);
        }
    }
    public void Change()
    {
        Instantiate(anotherSwitch, transform.position, transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
