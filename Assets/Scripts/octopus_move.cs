using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class octopus_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h_oc = Input.GetAxis("Horizontal");
        float v_oc = Input.GetAxis("Vertical");
        Vector2 moveDir = (Vector2.up * v_oc) + (Vector2.right * h_oc);
       // tr.Translate(moveDir.normalized * Time.deltaTime * movespeed, Space.Self);
    }
}
