using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaccelTester : MonoBehaviour
{
// Minimum and maximum values for the transition.
   float minimum = 0;
   float maximum = Mathf.Abs(vQuatFinder.verticalGoldenAngle);

   public static float myNumber;

// Time taken for the transition.
   float duration = 10.0f;

   float startTime;

   void Start()
   {
       // Make a note of the time the script started.
       startTime = Time.time;
   }

   void Update()
   {
       maximum = Mathf.Abs(vQuatFinder.verticalGoldenAngle);
       // Calculate the fraction of the total duration that has passed.
       float t = (Time.time - startTime) / duration;
       myNumber = Mathf.SmoothStep(minimum, maximum, t);
   }
   //currently unused
}
