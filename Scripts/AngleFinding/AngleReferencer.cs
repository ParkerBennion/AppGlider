using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleReferencer : MonoBehaviour
{
    public Transform target;
    public Transform cubeLocal;
    private Vector3 targetCube;
    public Transform altitude;
    
    private void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);

        targetCube = cubeLocal.position;
    }

    private void FixedUpdate()
    {
        transform.rotation = new Quaternion(0, 0, 0, 0);
        transform.position = targetCube;
        
    }
}
