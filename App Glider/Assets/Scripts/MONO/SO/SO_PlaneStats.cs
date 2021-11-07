using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class SO_PlaneStats : ScriptableObject
{
    public float fuel;// Fuel Amount
    public float soEngineDelta;// accel and decel
    public float soGrav; //"Plane Mass" literally how much gravity
    public float soEngineTarget; //Max Speed
    public float soTurning;//Left Right moblity

    
    public void AddFuel(float addNum)
    {
        fuel += addNum;
        fuel = Mathf.Clamp(fuel, 0, 500);
    }
    public void AddDelta(float addNum)
    {
        soEngineDelta += addNum;
        soEngineDelta = Mathf.Clamp(soEngineDelta, 0, 10);
    }
    public void AddMaxSpeed(float addNum)
    {
        soEngineTarget += addNum;
        soEngineTarget = Mathf.Clamp(soEngineTarget, 0, 10);
    }
    public void AddTurning(float addNum)
    {
        soTurning += addNum;
        soTurning = Mathf.Clamp(soTurning, 0, 10);
    }
    public void AddGrav(float addNum)
    {
        soGrav += addNum;
        soGrav = Mathf.Clamp(soGrav, 0, 10);
    }
    // to make script more versatile i could make min and max variables and plug them into each eqation making it editable 
    // in the editor in place of writing it all here.
}
