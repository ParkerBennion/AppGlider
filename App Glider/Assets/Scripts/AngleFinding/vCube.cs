using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vCube : MonoBehaviour
{
    private Vector3 cubeLocation;
    
    public static Vector3 secondCubeLocation;

    public static float vyCord;
    
    void Update()
    {
        cubeLocation = transform.position;
        //assign vector3
        secondCubeLocation = new Vector3(cubeLocation.x, Glide.craftPos.y, cubeLocation.z);
        //create new vector 3 and use its position in ccc.
    }
}
