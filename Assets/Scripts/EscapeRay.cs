using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EscapeRay : MonoBehaviour
{
    public Transform tr;
    public Transform awayTr;
    public List<Transform> hitList = new List<Transform>();
    public List<Transform> awayList = new List<Transform>();
    public float Distance;
    public List<float> DistanceList = new List<float>();
    public float speed;
    public Transform Up;
    public Transform Down;
    public Transform Right;
    public Transform Left;
    public Transform Corner1;
    public Transform Corner2;
    public Transform Corner3;
    public Transform Corner4;
    public float speed2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hitList.Clear();
        DistanceList.Clear();
        awayList.Clear();
        RaycastHit2D hitUp = Physics2D.Raycast(Up.position, Vector2.up);
        RaycastHit2D hitUp1 = Physics2D.Raycast(Corner1.position, Vector2.up);
        RaycastHit2D hitUp4 = Physics2D.Raycast(Corner4.position, Vector2.up);
        RaycastHit2D hitDown = Physics2D.Raycast(Down.position, Vector2.down);
        RaycastHit2D hitDown2 = Physics2D.Raycast(Corner2.position, Vector2.down);
        RaycastHit2D hitDown3 = Physics2D.Raycast(Corner3.position, Vector2.down);
        RaycastHit2D hitRight = Physics2D.Raycast(Right.position, Vector2.right);
        RaycastHit2D hitRight1 = Physics2D.Raycast(Corner1.position, Vector2.right);
        RaycastHit2D hitRight2 = Physics2D.Raycast(Corner2.position, Vector2.right);
        RaycastHit2D hitLeft = Physics2D.Raycast(Left.position, Vector2.left);
        RaycastHit2D hitLeft3 = Physics2D.Raycast(Corner3.position, Vector2.left);
        RaycastHit2D hitLeft4 = Physics2D.Raycast(Corner4.position, Vector2.left);
        if (hitUp.collider.tag != "Player")
        {
            Distance = (hitUp.transform.position - transform.position).magnitude;
            hitList.Add(hitUp.transform);
            DistanceList.Add(Distance);
        }
        else awayList.Add(hitUp.transform);

        if (hitUp1.collider.tag != "Player")
        {
            Distance = (hitUp1.transform.position - transform.position).magnitude;
            hitList.Add(hitUp1.transform);
            DistanceList.Add(Distance);
        }
        else awayList.Add(hitUp1.transform);

        if (hitUp4.collider.tag != "Player")
        {
            Distance = (hitUp4.transform.position - transform.position).magnitude;
            hitList.Add(hitUp4.transform);
            DistanceList.Add(Distance);
        }
        else awayList.Add(hitUp4.transform);

        if (hitDown.collider.tag != "Player")
        {
            Distance = (hitDown.transform.position - transform.position).magnitude;
            hitList.Add(hitDown.transform);
            DistanceList.Add(Distance);
        }
        else awayList.Add(hitDown.transform);

        if (hitDown2.collider.tag != "Player")
        {
            Distance = (hitDown2.transform.position - transform.position).magnitude;
            hitList.Add(hitDown2.transform);
            DistanceList.Add(Distance);
        }
        else awayList.Add(hitDown2.transform);

        if (hitDown3.collider.tag != "Player")
        {
            Distance = (hitDown3.transform.position - transform.position).magnitude;
            hitList.Add(hitDown3.transform);
            DistanceList.Add(Distance);
        }
        else awayList.Add(hitDown3.transform);

        if (hitRight.collider.tag != "Player")
        {
            Distance = (hitRight.transform.position - transform.position).magnitude;
            hitList.Add(hitRight.transform);
            DistanceList.Add(Distance);
        }
        else awayList.Add(hitRight.transform);

        if (hitRight1.collider.tag != "Player")
        {
            Distance = (hitRight1.transform.position - transform.position).magnitude;
            hitList.Add(hitRight1.transform);
            DistanceList.Add(Distance);
        }
        else awayList.Add(hitRight1.transform);

        if (hitRight2.collider.tag != "Player")
        {
            Distance = (hitRight2.transform.position - transform.position).magnitude;
            hitList.Add(hitRight2.transform);
            DistanceList.Add(Distance);
        }
        else awayList.Add(hitRight2.transform);

        if (hitLeft.collider.tag != "Player")
        {
            Distance = (hitLeft.transform.position - transform.position).magnitude;
            hitList.Add(hitLeft.transform);
            DistanceList.Add(Distance);
        }
        else awayList.Add(hitLeft.transform);

        if (hitLeft3.collider.tag != "Player")
        {
            Distance = (hitLeft3.transform.position - transform.position).magnitude;
            hitList.Add(hitLeft3.transform);
            DistanceList.Add(Distance);
        }
        else awayList.Add(hitLeft3.transform);

        if (hitLeft4.collider.tag != "Player")
        {
            Distance = (hitLeft4.transform.position - transform.position).magnitude;
            hitList.Add(hitLeft4.transform);
            DistanceList.Add(Distance);
        }
        else awayList.Add(hitLeft4.transform);

        float ma = DistanceList.Max();
        int i = DistanceList.IndexOf(ma);
        tr = hitList[i];
        Vector3 Dir = tr.position - transform.position;
        if(awayList.Count > 0)
        {
            awayTr = awayList[0];
        }
        Vector3 away = transform.position - awayTr.position;
        Vector3 awayReal = away.normalized / away.magnitude;
        transform.Translate(Dir.normalized * Time.deltaTime * speed);
        transform.Translate(awayReal * Time.deltaTime * speed2);
    }
}
