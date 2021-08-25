using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobility : MonoBehaviour
{
    private Rigidbody player;
    static public Vector3 mainPosition;

    private void Start()
    {
        GetComponent<Rigidbody>();
    }

    private void Update()
    {
        mainPosition = transform.position;
        Debug.Log(mainPosition);
    }
    // currently not used....
}
