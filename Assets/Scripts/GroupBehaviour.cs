using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupBehaviour : MonoBehaviour {
    public Vector3 speed = Vector3.forward;
    public List<GameObject> separationNeighbors = new List<GameObject>();
    public float separationDistance = 6;//分离距离
    public float noCollideDistance = 3;
    public List<GameObject> noCollideNeighbors = new List<GameObject>();
    public Vector3 sumForce = Vector3.zero;
    public float m = 10;//物体质量
    public Vector3 separationForce = Vector3.zero;//分离力
    public Vector3 noCollideForce = Vector3.zero;
    public float separationWeight = 1; //分离权重
    public float noCollideWeight = 20;
    public Vector3 alighmentForce = Vector3.zero;//队列力
    public float alighmentDistance = 10;
    public List<GameObject> alighmentNeighbors = new List<GameObject>();
    public float alighmentWeight = 1;
    public Vector3 cohesionForce = Vector3.zero;//聚集力
    public float cohesionWeight = 1f;
    public float checkInterval = 0.1f;
    public Vector3 moveToTarget = Vector3.zero;
    public float moveBackWeight = 1;
    public float stopDistance = 0.6f;
    public List<GameObject> stopNeighbour = new List<GameObject>();
	// Use this for initialization
	void Start () {
        InvokeRepeating("CalcForce", 0, checkInterval);
	}
	void CalcForce()
    {
        moveToTarget = Vector3.zero;
        sumForce = Vector3.zero;
        separationForce = Vector3.zero;
        alighmentForce = Vector3.zero;
        cohesionForce = Vector3.zero;
        separationNeighbors.Clear();

        Collider2D[] coll = Physics2D.OverlapCircleAll(transform.position, separationDistance);
        foreach (Collider2D c in coll)
        {
            if (c != null && c.gameObject != this.gameObject)//遍历周围的小伙伴的碰撞体
            {
                separationNeighbors.Add(c.gameObject);
            }
        }
        foreach (GameObject neighbor in separationNeighbors)
        {
            Vector3 dir = transform.position - neighbor.transform.position;
            separationForce += dir.normalized / dir.magnitude;
        }
        if (separationNeighbors.Count > 0)
        {
            separationForce *= separationWeight;
            sumForce += separationForce;
        }
        noCollideNeighbors.Clear();
        Collider2D[] noCollide = Physics2D.OverlapCircleAll(transform.position, noCollideDistance);
        foreach(Collider2D s in noCollide)
        {
            if (s != null && s.gameObject != this.gameObject && s.gameObject.tag == "Pal")
            {
                noCollideNeighbors.Add(s.gameObject);
            } 
        }
        if(noCollideNeighbors.Count > 0)
        {
            noCollideForce *= noCollideWeight;
            if(float.IsInfinity(noCollideForce.x) || float.IsInfinity(noCollideForce.y))
            {
                noCollideForce =Vector3.zero;
            }
            sumForce += noCollideForce;
        }
        foreach(GameObject neighbour in noCollideNeighbors)
        {
            Vector3 noDir = transform.position - neighbour.transform.position;
            noCollideForce += noDir.normalized / noDir.magnitude;
        }
        alighmentNeighbors.Clear();
        coll = Physics2D.OverlapCircleAll(transform.position, alighmentDistance);
        foreach (Collider2D c in coll)
        {
            if (c != null && c.gameObject != this.gameObject && c.gameObject.tag == "Player")//遍历周围的小伙伴的碰撞体
            {
                alighmentNeighbors.Add(c.gameObject);
            }
        }
        Vector3 avgDir = Vector3.zero;
        foreach (GameObject n in alighmentNeighbors)
        {
            avgDir += n.transform.forward;
        }
        if (alighmentNeighbors.Count > 0)
        {
            avgDir /= alighmentNeighbors.Count;
            alighmentForce = avgDir - transform.forward;
            alighmentForce *= alighmentWeight;
            sumForce += alighmentForce;
        }

        Vector3 center = Vector3.zero;
        foreach (GameObject n in alighmentNeighbors)
        {
            center += n.transform.position;
        }
        center /= alighmentNeighbors.Count;
        Vector3 dirtoCenter = center - transform.position;
        cohesionForce += dirtoCenter;
        cohesionForce *= cohesionWeight;
        sumForce += cohesionForce;
        Vector3 moveBack = GameObject.FindWithTag("Player").transform.position - transform.position;
        moveToTarget += moveBack;
        moveToTarget *= moveBackWeight;
        sumForce += moveToTarget;
        stopNeighbour.Clear();
        Collider2D[] collide = Physics2D.OverlapCircleAll(transform.position, stopDistance);
        foreach(Collider2D b in collide)
        {
            if(b != null && b.gameObject != this.gameObject)
            {
                stopNeighbour.Add(b.gameObject);
            }
        }
        Vector3 stopDir = GameObject.FindWithTag("Player").transform.position - transform.position;
        if(stopNeighbour.Count == 0 && stopDir.magnitude <= 2)
        {
            sumForce = Vector3.zero;
        }
        if (float.IsNaN(sumForce.x) || float.IsNaN(sumForce.y) || float.IsNaN(sumForce.z))
        {
            sumForce = moveToTarget;
        }
    }
	// Update is called once per frame
	void Update () {
        Vector3 a = sumForce /m ;
        speed += a * Time.deltaTime;
        if(speed.magnitude > 5)
        {
            speed = speed.normalized * 5;
        }
        //transform.rotation = Quaternion.LookRotation(speed,Vector2.right);
        transform.Translate(speed * Time.deltaTime, Space.World);
	}
}
