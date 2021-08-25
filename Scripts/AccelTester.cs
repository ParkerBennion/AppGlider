using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelTester : MonoBehaviour
{
    public static float currStrength = 0 ;
    public static float maxStrength;
    public static float recoveryRate;

    void Update()
    {
        recoveryRate = Mathf.Abs(vQuatFinder.verticalGoldenAngle);
        if (recoveryRate<=10)
        {
            recoveryRate = 10;
        }
        
        // this scrip finds the vertical angle of the craft divides that by 3 and sets "recoveryRate" at the rate at which it approaches the vertical angle.
        // (if angle is 30 then this will approach at 10 per second) if it is below 6 it is set to 6.
        // currStrength is the only variable that leaves. this number should allways be lagging behind the true vertical angle of the craft.
        // line 330 in glide currstrenght is inverted and used to find the momentum variable.
        // momentum is then added to engine power to get power.
        // "power" is the only variable that moves the ship (other than thrust which is unrelated here)
        // enginePower approaces 15 at the rate of engine delta and then becomes fixed unless the delta is moved or the 15 is changed. engine power is locked above 0 to prevent reverse unless momentum is in the negative
        // 
        maxStrength = vQuatFinder.verticalGoldenAngle/6;
        currStrength = Mathf.MoveTowards(currStrength, maxStrength, recoveryRate * Time.deltaTime);
    }
}

