using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCmove : MonoBehaviour
{
    public List<GameObject> MovePoints = new List<GameObject>();
    public float speed;
    public GameObject target;
    public float interval;
    // Start is called before the first frame update
    public void Move(int Point)
    {
        target = MovePoints[Point];
        InvokeRepeating("KeepMoving", 0, interval);
        transform.position = Vector2.MoveTowards(transform.position, MovePoints[Point].transform.position, Time.deltaTime * speed);
        if (transform.position == MovePoints[Point].transform.position)
        {
            GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
        }
    }
    public void KeepMoving()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
        if (transform.position == target.transform.position)
        {
            GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
        }
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
