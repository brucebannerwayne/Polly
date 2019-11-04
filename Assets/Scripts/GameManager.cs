using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public Transform revive;
    public GameObject player;
    //public Animator a;
    //public Transform octopus;
    public void Checkpoint(Transform revivePosition)
    {
        revive = revivePosition;
    }
    public void Revive()
    {
        player.transform.position = revive.transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        //a = GameObject.Find("Anchor").GetComponent<Animator>();
    }
       

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindWithTag("Player");
    }
 
   
}
