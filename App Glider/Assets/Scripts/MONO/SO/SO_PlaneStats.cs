using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class SO_PlaneStats : ScriptableObject
{
    public float thrust;// temporary boost
    public float soEngineDelta;// accel and decel
    public float soGrav; //"Plane Mass" literally how much gravity
    public float soEngineTarget; //Max Speed
    public float soTurning;//Left Right moblity
    public int soCurrentBoost;
    
    public void AddThrust(float addNum)
    {
        thrust += addNum;
    }
    public void AddDelta(float addNum)
    {
        soEngineDelta += addNum;
    }
    public void AddGrav(float addNum)
    {
        soGrav += addNum;
    }
    public void AddMaxSpeed(float addNum)
    {
        soEngineTarget += addNum;
    }
    public void AddTurning(float addNum)
    {
        soTurning += addNum;
    }
    public void AddBoost(int addNum)
    {
        thrust += addNum;
    }
}
