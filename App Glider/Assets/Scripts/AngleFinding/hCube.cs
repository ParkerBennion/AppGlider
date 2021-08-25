using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hCube : MonoBehaviour
{
    private Vector3 cubeLocation;

    public static Vector3 bobberHCubeLocation;
    
    public static float hyCord;
    
    void Update()
    {
        cubeLocation = transform.position;
        //assign vector3
        bobberHCubeLocation = new Vector3(cubeLocation.x, Glide.craftPos.y, cubeLocation.z);
        //create new vector 3 and use its position in hLevel.
        hyCord = transform.position.y;
        //used to make angle positive or negative
    }
}
