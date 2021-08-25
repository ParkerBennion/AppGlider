using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XYAngleFinder : MonoBehaviour
{
    public static Quaternion fixedQuat;
    public static Vector3 fixedVec;

    private void FixedUpdate()
    {
        
        transform.position = Glide.craftPos;
        
        Quaternion fixedQuat = new Quaternion(0, Glide.craftRot.y,0, Glide.craftRot.w);
        transform.rotation = fixedQuat;
        
    }
    //located on god object. currently not in use due to bugs.
}
