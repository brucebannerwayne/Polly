using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirMovement : MonoBehaviour
{
    public Vector2 move = Vector2.zero;
    public void Move(Vector2 moveForce)
    {
        InvokeRepeating("Movement", 0, 0.1f);
        move = moveForce;
    }
    public void Movement()
    {
        transform.Translate(move * Time.deltaTime,Space.Self);
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
