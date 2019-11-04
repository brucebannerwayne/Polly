using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSwitch : MonoBehaviour
{
    public int AMax;
    public int ANow;
    public int BMax;
    public int BNow;
    public int CMax;
    public int CNow;
    public GameObject targetA;
    public GameObject targetB;
    public GameObject targetC;

    public void AtoB()
    {
        int temp = BMax - BNow;
        if (temp > 0)
        {
            if (ANow >= temp)
            {
                BNow = BMax;
                ANow -= temp;
            }
            else if (ANow < temp)
            {
                BNow += ANow;
                ANow = 0;
            }
        }
        targetA.SendMessage("Move", ANow);
        targetB.SendMessage("Move", BNow);
    }

    public void BtoA()
    {
        int temp = AMax - ANow;
        if (temp > 0)
        {
            if (ANow >= temp)
            {
                ANow = AMax;
                BNow -= temp;
            }
            else if (ANow < temp)
            {
                ANow += BNow;
                BNow = 0;
            }
        }
        targetA.SendMessage("Move", ANow);
        targetB.SendMessage("Move", BNow);
    }
    public void AtoC()
    {
        int temp = CMax - CNow;
        if (temp > 0)
        {
            if (ANow >= temp)
            {
                CNow = CMax;
                ANow -= temp;
            }
            else if (ANow < temp)
            {
                CNow += ANow;
                ANow = 0;
            }
        }
        targetA.SendMessage("Move", ANow);
        targetC.SendMessage("Move", CNow);
    }
    public void CtoA()
    {
        int temp = AMax - ANow;
        if (temp > 0)
        {
            if (CNow >= temp)
            {
                ANow = AMax;
                CNow -= temp;
            }
            else if (CNow < temp)
            {
                ANow += CNow;
                CNow = 0;
            }
        }
        targetA.SendMessage("Move", ANow);
        targetC.SendMessage("Move", CNow);
    }
    public void CtoB()
    {
        int temp = BMax - BNow;
        if (temp > 0)
        {
            if (CNow >= temp)
            {
                BNow = BMax;
                CNow -= temp;
            }
            else if (ANow < temp)
            {
                BNow += CNow;
                CNow = 0;
            }
        }
        targetB.SendMessage("Move", BNow);
        targetC.SendMessage("Move", CNow);
    }
    public void BtoC()
    {
        int temp = CMax - CNow;
        if (temp > 0)
        {
            if (BNow >= temp)
            {
                CNow = CMax;
                BNow -= temp;
            }
            else if (BNow < temp)
            {
                CNow += BNow;
                BNow = 0;
            }
        }
        targetB.SendMessage("Move", BNow);
        targetC.SendMessage("Move", CNow);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
