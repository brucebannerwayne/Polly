using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
//make the electric orb follows the path which has a smaller electric resistence
public class ElectricOrb : MonoBehaviour
{

    public List<GameObject> Open = new List<GameObject>();
    public List<GameObject> Close = new List<GameObject>();
    public List<int> OpenResist = new List<int>();
    public GameObject target;
    public bool canMove = true;
    public float checkDistance;
    public float speed;
    public Vector2 deleteDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SelfDestruction()
    {
        Destroy(gameObject, 1);
    }
    // Update is called once per frame
    void Update()
    {
        PathFind();
    }
    public void PathFind()
    {
        OpenResist.Clear();
        if (canMove == true)
        {
            
            Open.Clear();
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, checkDistance);
            foreach (Collider2D c in colliders)
            {
                if (c.gameObject != this.gameObject && (c.gameObject.tag == "Circuit" || c.gameObject.tag == "Iron"))
                {
                    Open.Add(c.gameObject);
                    OpenResist.Add(c.gameObject.GetComponent<Resistance>().ohm);
                }
                if (Close.Contains(c.gameObject))
                {
                    Open.Remove(c.gameObject);
                    OpenResist.Remove(c.gameObject.GetComponent<Resistance>().ohm);
                }
            }
            switch (Open.Count)
            {
                case 0:
                    Destroy(gameObject);
                    break;
                case 1:
                    target = Open[0];
                    break;
                default:
                    int m = OpenResist.Min();
                    int index = OpenResist.IndexOf(m);
                    target = Open[index];
                    break;

            }
            canMove = false;
            Close.AddRange(Open);
            Close.Remove(target);
        }
        /*if (Open.Count > 0)
        {
            for (int i = 1; i <= Open.Count; i++)
            {
                Vector3 Delete = Vector3.zero;
                Delete = Open[i].transform.position - transform.position;
                if (Delete.magnitude > 3)
                {
                    Open.Remove(Open[i]);
                    OpenResist.Remove(Open[i].GetComponent<Resistance>().ohm);
                    Close.Add(Open[i]);
                }
            }
        }*/

        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
        deleteDistance = target.transform.position - transform.position;
        if (deleteDistance.magnitude == 0)
        {

            Open.Remove(target);
            OpenResist.Remove(target.GetComponent<Resistance>().ohm);
            Close.Add(target);
            canMove = true;
        }
    }
}
