using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hLevel : MonoBehaviour
{
    public Transform targetTwo;
    
    void Update()
    {
        Vector3 relativePos = targetTwo.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);

    }

    private void FixedUpdate()
    {
        transform.position = hCube.bobberHCubeLocation;
    }
}
