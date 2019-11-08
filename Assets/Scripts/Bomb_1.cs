using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script used to control puffer
public class Bomb_1 : MonoBehaviour
{
    public Transform tr;
    //public GameObject friend;
    public float speed;
    public GameObject exploEffect;
    public bool aimat = true;
    private Vector3 aimDir;
    private Vector3 aimDir2;
    public float aimspeed;

    void Flip()//fire direction
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    public void SelfDestroy()
    {
        // GameObject.Find("Mipha").gameObject.GetComponent<PlayerMovement>().bombNum = 1;
        Destroy(gameObject);
    }

    public void SetOff(Vector2 bombDir)//fire the puffer
    {
        //Debug.Log("123");
        GetComponent<Rigidbody2D>().AddForce(bombDir * speed);

    }
    public void Explode()//puffer explode
    {
        GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().bombNum = 1;
        Invoke("reallyexplode", 3f);
    }
    public void reallyexplode()
    {
        Instantiate(exploEffect, transform.position, transform.rotation);
        //GameObject.FindWithTag("obstacle").SendMessage("SelfDestroy");
        //GameObject.FindWithTag("LargeIron").SendMessage("SelfDestroy");//所有obstacles??
        GameObject.Find("puffer fish").gameObject.GetComponent<SpriteRenderer>().enabled = true;
        Destroy(gameObject);
    }
    // Use this for initialization
    void Start()
    {
        tr = GetComponent<Transform>();
        if (GameObject.FindWithTag("Player").gameObject.GetComponent<PlayerMovement>().isright == true)
            Flip();
    }

    // Update is called once per frame
    void Update()
    {
        if (aimat)//fire the puffer
        {
           
            float ha = Input.GetAxis("Aim");
            float va = Input.GetAxis("Aim1");
            aimDir = (Vector2.up * va) + (Vector2.right * ha);
            if (GameObject.FindWithTag("Player").gameObject.GetComponent<PlayerMovement>().isright == true)
            {
                Vector3 c = new Vector3(aimDir.x, -aimDir.y, 0);
                aimDir2 = c;//- transform.rotation;
                aimDir2.z = 0;//这个2d下，可能写不写无所谓
                aimDir2.Normalize();
                float target = Mathf.Atan2(aimDir2.y, aimDir2.x) * Mathf.Rad2Deg;
                
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, target), aimspeed * Time.deltaTime);
            }
            if (GameObject.FindWithTag("Player").gameObject.GetComponent<PlayerMovement>().isright == false)
            {
                Vector3 c = new Vector3(aimDir.x, aimDir.y, 0);
                aimDir2 = c;//- transform.rotation;
                aimDir2.z = 0;//这个2d下，可能写不写无所谓
                aimDir2.Normalize();
                float target = Mathf.Atan2(aimDir2.y, -aimDir2.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, target), aimspeed * Time.deltaTime);
            }
        }
    }
}
