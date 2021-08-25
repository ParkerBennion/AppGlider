using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostAccel : MonoBehaviour
{
    public static float engineCurrent =0;
    public float engineMaximum = 13;
    public float engineAccel =1;

    // Update is called once per frame
    void Update()
    {
        if (Glide.engineOn)
        {
            engineCurrent = Mathf.MoveTowards(engineCurrent, engineMaximum, engineAccel * Time.deltaTime);
        }
        
    }
}
