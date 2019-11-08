using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script used to control player's movement
public class PlayerMovement : MonoBehaviour {
    private Transform tr;
    public float speed;
    private bool isrush;
    public Vector3 playerPosition;
    private Animator miphaanim;
    public GameObject bomb;
    public int bombNum = 1;
    public GameObject generator;
    public int generatorNum = 1;
    public GameObject octopus;
    public int octopusNum = 1;
    public GameObject hipp;
    public int hippNum = 1;
    public float ha;
    public float va;
    public Vector2 bombDir = Vector2.zero;
    public Vector2 octopusDir = Vector2.zero;
    public bool Setbomb;
    public bool SetGenerator;
    public bool Sethipp;
    public bool Setoctopus;
    public bool isright = true;
    public Transform target;
    public GameObject friends_hipp;
    public GameObject friends_octo;
    public GameObject friends_elet;
    public GameObject friends_bomb;
    private bool isride;
    public float rotSpeed=5f;
    private bool isrushing = true;
    public float rushspeed=20f;
    public Animator reborn;
    public GameObject useitem;
    public Animator eleanim;
    public GameObject eleusing;
   

    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    void Rush()
    {

    }

    // Use this for initialization
    void Start () {
        miphaanim=GetComponent<Animator>();
        reborn = GameObject.Find("rebornposition").gameObject.GetComponent<Animator>();
        tr = GetComponent<Transform>();
        playerPosition = transform.position;
       // eleanim = eleusing.gameObject.GetComponent<Animator>();
        
    }
    //private void FixedUpdate()
    //{
    //    float h = Input.GetAxis("Horizontal");
    //    float v = Input.GetAxis("Vertical");
    //    Vector2 moveDir = (Vector2.up * v) + (Vector2.right * h);
    //}
    // Update is called once per frame
    void Update () {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        ha = Input.GetAxis("Aim");
        va = Input.GetAxis("Aim1");

        float hs = Input.GetAxis("ItemSelectH");
        float vs = Input.GetAxis("ItemSelectV");

        Vector2 moveDir = (Vector2.up * v) + (Vector2.right * h);
        if (Sethipp && Input.GetKeyDown(KeyCode.Joystick1Button5)&&isrushing)
        {
            speed = rushspeed;
            isrush = true;
            isrushing = false;
            //Mathf.Clamp01(2, 1);
            //speed += Time.timeScale;
            //tr.Translate(moveDir.normalized * speed , Space.Self);
        }
        else
        {
            if (isrush)
            {
                speed -= 1f;
                if (speed < 3)
                {
                    isrush = false;
                    isrushing = true;
                }
             }
            
            tr.Translate(moveDir.normalized * Time.deltaTime * speed, Space.Self);
        }

        if (h<0)
        {
            if (isright)
            {
                Flip();
                isright = false;
            }
            
            //Vector3 a = new Vector3(0, 0, -moveDir.y);
            //if (transform.localEulerAngles.z > 30 || transform.localEulerAngles.z < 330)
            //{

            //    moveDir.y = 0;
            //}
            ////Debug.Log(transform.localEulerAngles.z);
            //transform.Rotate(a * rotSpeed * Time.timeScale);
         
        }


        if (h> 0)
        {
            //Quaternion qua = Quaternion.LookRotation(new Vector3(transform.position.x, transform.position.y, transform.position.z + 10 * h));
            //transform.rotation = qua;
            if (!isright)
            {
                Flip();
                isright = true;
            }
            //Vector3 b = new Vector3(0, 0, moveDir.y);
            //if (transform.localEulerAngles.z < 30 || (transform.localEulerAngles.z < 360 && transform.localEulerAngles.z > 330))
            //{
            //    transform.Rotate(b * rotSpeed * Time.timeScale);
            //}
        }
        //if(h==0)
        //{
        //    Vector3 c = new Vector3(0, 0, 0);
        //    Quaternion lookRot = Quaternion.LookRotation(c);
        //    transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, Mathf.Clamp01(rotSpeed * Time.deltaTime));
        //}
        



      
        //Quaternion lookRot = Quaternion.LookRotation(a);
        //transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, Mathf.Clamp01(rotSpeed * Time.deltaTime));



        //transform.localRotation = Quaternion.
        
        //puffer control
        if (hs > 0 && vs == 0 && bombNum > 0)
        {
            bombNum = 0;
            Instantiate(useitem, target.position, target.rotation);
            Instantiate(bomb, target.position, target.rotation);
            GameObject.FindWithTag("bomb").GetComponent<Bomb_1>().aimat =true;
            //bomb.transform.parent = gameObject.transform;
            Setbomb = true;
            friends_bomb.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button1) && bombNum == 0)
        {
            GameObject.FindWithTag("bomb").GetComponent<Bomb_1>().aimat = false;
            GameObject.FindWithTag("bomb").SendMessage("SelfDestroy");
            bombNum = 1;
            Setbomb = false;
            friends_bomb.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Joystick1Button9) && Setbomb == true)
        {
            GameObject.FindWithTag("bomb").GetComponent<Bomb_1>().aimat = false;
            Setbomb = false;
            bombDir = (Vector2.up * -va) + (Vector2.right * ha);
            GameObject.FindWithTag("aim").gameObject.GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindWithTag("bomb").SendMessage("SetOff", bombDir);
            
        }
        //Electric Ray
        if (hs == 0 && vs > 0 && generatorNum > 0)
        {
            Instantiate(useitem, target.position, target.rotation);
            Instantiate(generator, target.position, target.rotation);
            //bomb.transform.parent = gameObject.transform;
            generatorNum = 0;
            SetGenerator = true;
            friends_elet.gameObject.GetComponent<SpriteRenderer>().enabled =false;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button1) && generatorNum == 0)
        {
            GameObject.FindWithTag("Generator").SendMessage("SelfDestroy");
            generatorNum = 1;
            SetGenerator = false;
            friends_elet.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Joystick1Button9) && SetGenerator == true)
        {
            //eleanim.SetBool("iseletricc", true);
            SetGenerator = false;
            GameObject.FindWithTag("Generator").SendMessage("SetOff");
        }

        //octopus
        if (hs == 0 && vs < 0 && octopusNum > 0)
        {
            Instantiate(useitem, target.position, target.rotation);
            Instantiate(octopus, target.position, target.rotation);
            GameObject.FindWithTag("octopus").GetComponent<Bomb>().aimat = true;
            //bomb.transform.parent = gameObject.transform;
            octopusNum = 0;
            Setoctopus = true;
            friends_octo.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button1) && octopusNum == 0)
        {
            GameObject.FindWithTag("octopus").GetComponent<Bomb>().aimat = false;
            GameObject.FindWithTag("octopus").SendMessage("SelfDestroy");
            octopusNum = 1;
            Setoctopus = false;
            friends_octo.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Joystick1Button9) && Setoctopus == true)
        {
            GameObject.FindWithTag("octopus").GetComponent<Bomb>().aimat = false;
            Setoctopus = false;
            octopusDir = (Vector2.up * -va) + (Vector2.right * ha);
            GameObject.FindWithTag("aim").gameObject.GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindWithTag("octopus").SendMessage("SetOff", octopusDir);
        }

        //hip sprint
        if (hs < 0 && vs == 0 && hippNum > 0)
        {
            // Instantiate(octopus, target.position, target.rotation);
            //bomb.transform.parent = gameObject.transform;
                hippNum = 0;
            Sethipp = true;
            miphaanim.SetBool("Ride", true);
            friends_hipp.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }

            
        if (Input.GetKeyDown(KeyCode.Joystick1Button1) && hippNum == 0)
        {
            miphaanim.SetBool("Ride", false);
            friends_hipp.gameObject.GetComponent<SpriteRenderer>().enabled = true;
           // GameObject.FindWithTag("hipp").SendMessage("SelfDestroy");
            hippNum = 1;
            Sethipp = false;
          
        }
    }
    public void StreamEffect(Vector2 streamForce)
    {
        transform.Translate(streamForce * Time.timeScale);
    }
    public void PlayerDead()
    {
        miphaanim.SetTrigger("isDead");
      
        
        //Destroy(gameObject);
    }
    void DeadtoRevive()
    {
        //Debug.Log(22);
        reborn.SetTrigger("isReborn");
        GameObject.FindWithTag("GameManager").SendMessage("Revive");
    }
}
