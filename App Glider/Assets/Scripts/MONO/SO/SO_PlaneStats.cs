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
    public SO_FloatTracker money;

    public void AddFuel(float addNum)
    {
        if (money.baseInt >= 1 && fuel < 50)
        {
            fuel += addNum;
            fuel = Mathf.Clamp(fuel, 0, 50);
            money.baseInt -= 1;
        }
        else
        {
            Debug.Log("NoMoMonies");
        }
    }
    public void AddDelta(float addNum)
    {
        if (money.baseInt >= 1 && soEngineDelta < 10)
        {
            soEngineDelta += addNum;
            soEngineDelta = Mathf.Clamp(soEngineDelta, 0, 10);
            money.baseInt -= 1;
        }
        else
        {
            Debug.Log("NoMoMonies");
        }
    }
    public void AddMaxSpeed(float addNum)
    {
        if (money.baseInt >= 1 && soEngineTarget < 10)
        {
            soEngineTarget += addNum;
            soEngineTarget = Mathf.Clamp(soEngineTarget, 0, 10);
            money.baseInt -= 1;
        }
        else
        {
            Debug.Log("NoMoMonies");
        }
    }
    public void AddTurning(float addNum)
    {
        if (money.baseInt >= 1 && soTurning < 10)
        {
            soTurning += addNum;
            soTurning = Mathf.Clamp(soTurning, 0, 10);
            money.baseInt -= 1;
        }
        else
        {
            Debug.Log("NoMoMonies");
        }
    }
    public void AddGrav(float addNum)
    {
        if (money.baseInt >= 1 && soGrav < 10)
        {
            soGrav += addNum;
            soGrav = Mathf.Clamp(soGrav, 0, 10);
            money.baseInt -= 1;
        }
        else
        {
            Debug.Log("NoMoMonies");
        }
    }
    
    
    
    
    
    
    public void MinFuel(float addNum)
    {
        if (fuel > 0)
        {
            fuel += addNum;
            fuel = Mathf.Clamp(fuel, 0, 500);
            money.baseInt += 1;
            Debug.Log("Refund");
        }
        else
        {
            Debug.Log("Cant Go Lower");
        }
    }
    public void MinDelta(float addNum)
    {
        if (soEngineDelta > 0)
        {
            soEngineDelta += addNum;
            soEngineDelta = Mathf.Clamp(soEngineDelta, 0, 10);
            money.baseInt += 1;
            Debug.Log("Refund");
        }
        else
        {
            Debug.Log("Cant Go Lower");
        }
    }
    public void MinMaxSpeed(float addNum)
    {
        if (soEngineTarget > 0)
        {
            soEngineTarget += addNum;
            soEngineTarget = Mathf.Clamp(soEngineTarget, 0, 10);
            money.baseInt += 1;
            Debug.Log("Refund");
        }
        else
        {
            Debug.Log("Cant Go Lower");
        }
    }
    public void MinTurning(float addNum)
    {
        if (soTurning > 0)
        {
            soTurning += addNum;
            soTurning = Mathf.Clamp(soTurning, 0, 10);
            money.baseInt += 1;
            Debug.Log("Refund");
        }
        else
        {
            Debug.Log("Cant Go Lower");
        }
    }
    public void MinGrav(float addNum)
    {
        if (soGrav > 0)
        {
            soGrav += addNum;
            soGrav = Mathf.Clamp(soGrav, 0, 10);
            money.baseInt += 1;
            Debug.Log("Refund");
        }
        else
        {
            Debug.Log("Cant Go Lower");
        }
    }
    
    
   /* public void AddMaxSpeed(float addNum, float min, float max)
    {
        soEngineTarget += addNum;
        soEngineTarget = Mathf.Clamp(soEngineTarget, min, max);
    }*/ // why doesnt this work?
    // to make script more versatile i could make min and max variables and plug them into each eqation making it editable 
    // in the editor in place of writing it all here.
}
