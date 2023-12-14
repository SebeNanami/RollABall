using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallData
{
    private int hitPoint;
    public int GetHitPoint
    {
        get { return hitPoint; }
    }
    public int SetHitPoint
    {
        set { hitPoint = value; }
    }
    public BallData(int hitPoint)
    {
        this.hitPoint = hitPoint;
    }

   
}

