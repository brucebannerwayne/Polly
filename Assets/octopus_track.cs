using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class octopus_track : MonoBehaviour
{
    public int point0;
    private bool up=true;
    private bool down=true;
    private bool right=true;
    private bool left=true;
    //public LayerMask a;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void moveOCTO()
    {
        
        if (up)
        {
            transform.Translate(new Vector3(0, 5));
            //transform.position += new Vector3();
        }
        if(down)
        {
            transform.Translate(new Vector3(0, -5));
        }
        if(left)
        {
            transform.Translate(new Vector3(-5, 0) );
        }
        if(right)
        {
            transform.Translate(new Vector3(5, 0) );
        }
        
    }
    // Update is called once per frame
    void Update()
    {

        RaycastHit2D hit1;
        hit1 = Physics2D.Raycast(transform.position, transform.up, 5f);
        //Debug.DrawLine(transform.position, hit1.point, Color.red);

        RaycastHit2D hit2;
        hit2 = Physics2D.Raycast(transform.position, -transform.up, 5f);
       //Debug.DrawLine(transform.position, hit2.point, Color.red);

        RaycastHit2D hit3;
        hit3 = Physics2D.Raycast(transform.position, -transform.right, 5f);
        //Debug.DrawLine(transform.position, hit3.point, Color.red);
        RaycastHit2D hit4;
        hit4 = Physics2D.Raycast(transform.position,transform.right, 5f);
        //Debug.Log(Vector3.right);
        //Debug.DrawLine(transform.position, hit4.point, Color.red);
        if (hit1.collider!=null)
        {
            if (hit1.collider.tag == "background")
            {
                up = false;
            }
        }
        if (hit2.collider != null)
        {
            if (hit2.collider.tag == "background")
            {
               down = false;
            }
        }
        if (hit3.collider != null)
        {
            if (hit3.collider.tag == "background")
            {
                left = false;
            }
        }
        if (hit4.collider != null)
        {
            if (hit4.collider.tag == "background")
            {
                right = false;
            }
        }
        if(point0==1)
        {
            if (hit1.collider != null)
            {
                if (hit1.collider.tag == "Player")
                {
                    up = false;
                    moveOCTO();//动画
                }
            }
            if (hit2.collider != null)
            {

                if (hit2.collider.tag == "Player")
                {
                    down = false;
                    moveOCTO(); //动画
                }
            }
            if (hit4.collider != null)
            {
                if (hit4.collider.tag == "Player")
                {
                    left = false;
                    moveOCTO();//动画
                }
            }
            if (hit4.collider != null)
            {
                if (hit4.collider.tag == "Player")
                {
                    right = false;
                    moveOCTO();//动画
                }
            }
            if(point0==2)
            {
                if (hit1.collider != null)
                {
                    if (hit1.collider.tag == "Player")
                    {
                        up = false;
                        moveOCTO();//动画
                    }
                }
                if (hit2.collider != null)
                {

                    if (hit2.collider.tag == "Player")
                    {
                        down = false;
                        moveOCTO(); //动画
                    }
                }
                if (hit3.collider != null)
                {
                    if (hit3.collider.tag == "Player")
                    {
                        left = false;
                        moveOCTO();//动画
                    }
                }
                if (hit4.collider != null)
                {
                    if (hit4.collider.tag == "Player")
                    {
                        right = false;
                        moveOCTO();//动画
                    }
                }
            }
        }
       
    }
}
