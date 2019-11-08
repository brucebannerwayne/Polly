using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make the octopus run away from player when player tries to catch it
public class EscapeFromPlayer : MonoBehaviour
{
    public List<GameObject> bounceOff = new List<GameObject>();
    public float OffDistance;
    public GameObject tr;
    public float speed;
    public float escapeDistance;
    public Vector3 escapeStrength;
    public Vector3 OffForce;
    public float speed2;
    // Start is called before the first frame update
    void Start()
    {
        tr = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        bounceOff.Clear();
        escapeStrength = Vector3.zero;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, escapeDistance);
        foreach(Collider2D c in colliders)
        {
            if(c.gameObject == tr)
            {
                escapeStrength = transform.position - tr.transform.position;
                transform.Translate(escapeStrength * Time.deltaTime*speed);
            }
        }
        OffForce = Vector3.zero;
        Collider2D[] coll = Physics2D.OverlapCircleAll(transform.position, OffDistance);
        foreach(Collider2D w in coll)
        {
            if(w.tag == "Wall")
            {
                bounceOff.Add(w.gameObject);
            }
        }
        foreach(GameObject neighBour in bounceOff)
        {
            OffForce = neighBour.transform.position - transform.position;
            if (OffForce.normalized == escapeStrength)
            {
                OffForce = Vector3.zero;
            }
        }
        transform.Translate(-OffForce * Time.deltaTime * speed2);
    }
}
