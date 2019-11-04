using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Escape : MonoBehaviour
{
    public Transform[] navPoints;
    public Transform Player;
    public float awayWeight;
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindWithTag("Player").transform;
        RunAway();
        
    }
    public void RunAway()
    {
        float furthestDistance = 0;
        Vector3 runPosition = Vector3.zero;
        foreach(Transform point in navPoints)
        {
            float currentCheckDistance = Vector3.Distance(Player.position, point.position);
            if(currentCheckDistance > furthestDistance)
            {
                furthestDistance = currentCheckDistance;
                runPosition = point.position;
            }
        }
        transform.Translate((runPosition - transform.position).normalized * speed * Time.deltaTime);
        Vector3 away = transform.position - Player.position;
        transform.Translate(away.normalized * awayWeight * Time.deltaTime * awayWeight);
    }
}
