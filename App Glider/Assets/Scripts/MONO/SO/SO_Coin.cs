using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class SO_Coin : ScriptableObject
{
    public UnityEvent collected;
    private bool collect = false;
    
    public void OnTriggerEnter(Collider other)
    {
        collect = true;
    }
}
