using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script used to close shell
public class CloseShell : MonoBehaviour
{
    public bool canRotate = true;
    public Transform tr;
    public float angle;
    public void Close()
    {
        
            InvokeRepeating("ShellClose", 0, 0.1f);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ShellClose()
    {
        if (canRotate == true)
        {
            transform.RotateAround(tr.position, new Vector3(0, 0, 1), angle * Time.deltaTime);
        }
        else return;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
