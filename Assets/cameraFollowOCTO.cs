using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowOCTO : MonoBehaviour
{
    public GameObject player;  //主角
    public float speed;  //相机跟随速度
    public float smoothX;
    public float smoothY;
    public float minPosx;  //相机不超过背景边界允许的最小值
    public float maxPosx;
    public float minPosy;
    public float maxPosy;//相机不超过背景边界允许的最大值
    public GameObject a;
    public GameObject player2;

   //public Transform playerTransform; // 移动的物体
    //public Vector3 deviation; // 偏移量

    void Start()
    {
        a = GameObject.Find("setcamera");
       // deviation = transform.position - playerTransform.position; // 初始物体与相机的偏移量=相机的位置 - 移动物体的偏移量
    }

    void Update()
    {
        transform.position= player.transform.position+a.transform.position;
        // playerTransform = GameObject.Find("GameManager").GetComponent<GameManager>().octopus.transform;
      //  transform.position = playerTransform.position+a.transform.position;//+ deviation; // 相机的位置 = 移动物体的位置 + 偏移量
        //Debug.Log(playerTransform.transform.position);

    }
}



        //// 先取得摄像机的初始位置
        //float cameraX = transform.position.x;
        //float cameraY = transform.position.y;



        //// 判断摄像机与物体之间的距离是否超过设定的值 value ，如果超过，则开始跟随
        //// 跟随时使用了平滑处理，而不是直接将跟随物体的 position 赋值给摄像机，即给一个中间值，让跟随效果更自然
        //if (Mathf.Abs(transform.position.x - player.transform.position.x) > 2)
        //    cameraX = Mathf.Lerp(transform.position.x, player.transform.position.x, smoothX * Time.deltaTime);
        //if (Mathf.Abs(transform.position.y - player.transform.position.y) > 0.7f)
        //    cameraY = Mathf.Lerp(transform.position.y, player.transform.position.y, smoothY * Time.deltaTime);




        //// 任然需要限制摄像机的边界
        //cameraX = Mathf.Clamp(cameraX, minPosx, maxPosx);
        //cameraY = Mathf.Clamp(cameraY, minPosy, maxPosy);



        //// 最后设置摄像机的位置
        //transform.position = new Vector3(cameraX, cameraY, transform.position.z);

       

        //    player = GameObject.FindWithTag("Player");
        //    //FixCameraPos();
        //    float x = Mathf.Clamp(player.transform.position.x, minPosx, maxPosx);
        //    float y = Mathf.Clamp(player.transform.position.y, minPosy, maxPosy);
        //    transform.position = new Vector3(x, y, transform.position.z);

        //}

        //void FixCameraPos()
        //{
        //    float pPosX = player.transform.position.x;  //主角 x轴方向 时实坐标值
        //    float cPosX = transform.position.x;             //相机 x轴方向 时实坐标值
        //    //if (pPosX - cPosX > 3)    // 并不是死死地跟随，是相机和主角之间距离超过某个值时才跟随
        //    //{
        //    //    transform.position = new Vector3(cPosX + speed, transform.position.y, transform.position.z);
        //    ////}
        //    //if (Mathf.Abs(pPosX - cPosX) > 3)
        //    //{
        //    //   cPosX= Mathf.Lerp(transform.position.x, cPosX, smooth * Time.deltaTime);
        //    //    transform.position = new Vector3(cPosX+speed, transform.position.y, transform.position.z);
        //    //}
        //    //if (pPosX - cPosX < -3)
        //    //{
        //    //    transform.position = new Vector3(cPosX - speed, transform.position.y, transform.position.z);
        //    //}
        //    float realPosX = Mathf.Clamp(transform.position.x, minPosx, maxPosx);// 相机X轴方向 限制移动区间，防止超过背景边界

        //transform.position = new Vector3(realPosX, transform.position.y, transform.position.z);
        //}
    

