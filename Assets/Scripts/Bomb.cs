using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//control the octopus
public class Bomb : MonoBehaviour {
    public Transform tr;
    public float speed;
   // private Vector2 a;
    public bool ismoveable=false;
    public bool isshoot=true;
    public float h_oc;
    public float v_oc;
    public float movespeed;
    public Vector2 octoDir;
    //public GameObject a;
    public GameObject octocamera;
    private bool octocam=true;
    public GameObject a;
    public bool aimat=true;
    private Vector3 aimDir;
    private Vector3 aimDir2;
    public float aimspeed;



    void Flip()//fire direction
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        //if(1)
        //gameObject.GetComponent<SpriteRenderer>().flipY=true;
    }

    public void SelfDestroy()//cancel the octopus
    {
        GameObject.Find("octopus 1").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().octopusNum = 1;
        
        Destroy(gameObject);
    }

    public void SetOff(Vector2 octopusDir)
    {
        //Debug.Log(octopusDir);
        if(isshoot)
        {
            GetComponent<Rigidbody2D>().AddForce(octopusDir * speed);
            octoDir = octopusDir;
            
            //gameObject.GetComponent<Rigidbody2D>().velocity = (bombDir.normalized * Time.deltaTime * speed);
        }
        // tr.Translate(bombDir.normalized * Time.deltaTime * speed, Space.Self);
        Explode();
    }
    public void Explode()
    {
        Destroy(gameObject,100);
    }
	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
        if (GameObject.FindWithTag("Player").gameObject.GetComponent<PlayerMovement>().isright == false)
        {
          
            Flip();
        } 
            //
        a = GameObject.Find("setcamera");
    }
	
	// Update is called once per frame
	void Update () {

       
            if (aimat)//fire the octopus
            {
                float ha = Input.GetAxis("Aim");
                float va = Input.GetAxis("Aim1");
                aimDir = (Vector2.up * va) + (Vector2.right * ha);
            if (GameObject.FindWithTag("Player").gameObject.GetComponent<PlayerMovement>().isright == true)
            {
                //Vector3 c = new Vector3(aimDir.x, -aimDir.y, 0);
                //aimDir2 = c;//- transform.rotation;
                //aimDir2.z = 0;//这个2d下，可能写不写无所谓
                //aimDir2.Normalize();
                //float target = Mathf.Atan2(aimDir2.y, aimDir2.x) * Mathf.Rad2Deg;
                //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, target), aimspeed * Time.deltaTime);
            }
            if (GameObject.FindWithTag("Player").gameObject.GetComponent<PlayerMovement>().isright ==false)
            {
                //Vector3 c = new Vector3(aimDir.x, aimDir.y, 0);
                //aimDir2 = c;//- transform.rotation;
                //aimDir2.z = 0;//这个2d下，可能写不写无所谓
                //aimDir2.Normalize();
                //float target = Mathf.Atan2(aimDir2.y, -aimDir2.x) * Mathf.Rad2Deg;
                //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, target),aimspeed * Time.deltaTime);
            }

            //Quaternion lookRot = Quaternion.LookRotation(c);
            //if(aimDir.x>0)
            //   transform.RotateAround(transform.position, new Vector3(0, 0, 1),c.y*2);
            //if(aimDir.x<0)
            //transform.LookAt
            //   transform.RotateAround(transform.position, new Vector3(0, 0, 1),- c.y * 2);
            //transform.rotation=Quaternion.Slerp(transform.rotation, lookRot, Mathf.Clamp01(1 * Time.deltaTime));
            // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(c - transform.position), 100* Time.deltaTime);
        }


        if (ismoveable)//use octopus to move items
        {
            if(octocam==true)
            {
              // Instantiate(octocamera, a.transform.position, a.transform.rotation);
                octocam = false;
            }

            // octocamera.gameObject.SetActive(true);

            //GameObject.Find("GameManager").gameObject.GetComponent<GameManager>().transform.position = this.transform.position;
            //GameObject.Find("Main Camera").gameObject.GetComponent<cameraFollowOCTO>().enabled = true;
            //GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().enabled = false;
            GameObject.Find("Main Camera").gameObject.GetComponent<Camera>().depth = -2;
            //octocamera.gameObject.GetComponent<Camera>().depth = 1;
            GameObject.Find("Mipha").gameObject.GetComponent<PlayerMovement>().enabled = false;
            GetComponent<Rigidbody2D>().AddForce(-octoDir * speed);
            gameObject.GetComponentInChildren<Rigidbody2D>().gravityScale = 0;
           h_oc = Input.GetAxis("Horizontal");
            v_oc = Input.GetAxis("Vertical");
            Vector2 moveDir = (Vector2.up * v_oc) + (Vector2.right * h_oc);
            tr.Translate(moveDir.normalized * Time.deltaTime * movespeed, Space.Self);
            if (Input.GetKeyDown(KeyCode.Joystick1Button1))//drop the item
            {
                 //DestroyImmediate(octocamera,true);
                    gameObject.GetComponentInChildren<Rigidbody2D>().gravityScale = 1;
                gameObject.transform.DetachChildren();
               // beMove.GetComponentInChildren<Rigidbody2D>().gravityScale = 1;
                Invoke("SelfDestroy", 3f);
                GameObject.Find("Mipha").gameObject.GetComponent<PlayerMovement>().enabled = true;
                //octocamera.gameObject.GetComponent<Camera>().depth =-1;
                GameObject.Find("Main Camera").gameObject.GetComponent<Camera>().depth = 0;
                //GameObject.Find("Main Camera").gameObject.GetComponent<cameraFollowOCTO>().enabled = false;
                //GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().enabled = true;
                ismoveable = false;
                octocam = true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obstacle" || collision.gameObject.tag == "Peral" || collision.gameObject.tag == "rock" || collision.gameObject.tag=="Iron")//move item
        {
            isshoot = false;
            speed = 0;
            collision.transform.parent =gameObject.transform;
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
           // beMove = collision.gameObject;
            ismoveable = true;
        }
    }
}
