using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vQuatFinder : MonoBehaviour
{
    public Transform targetBlue;
    public static float verticalGoldenAngle;
    public Transform altitudeRed, altitudeBlue;

    void Update()
    { 
        float angle = Quaternion.Angle(transform.rotation, targetBlue.rotation);

        if (altitudeBlue.position.y > altitudeRed.position.y )
        {
            verticalGoldenAngle = angle * -1;
        }
        else
        {
            verticalGoldenAngle = angle;
        }
    }
}
