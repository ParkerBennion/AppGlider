using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hQuatFinder : MonoBehaviour
{
    public Transform targetGreen;
    public static float horozontalGoldenAngle;
    public Transform altitudeOrange;
    public Transform altitudeGreen;
    
    void Update()
    { 
        float angle = Quaternion.Angle(transform.rotation, targetGreen.rotation);
        
        if (altitudeGreen.position.y > altitudeOrange.position.y )
        {
            horozontalGoldenAngle = angle * -1;
        }
        else
        {
            horozontalGoldenAngle = angle;
        }
    }



}
