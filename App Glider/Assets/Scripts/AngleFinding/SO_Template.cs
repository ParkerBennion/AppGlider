using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SO_Template : ScriptableObject
{
    public float value;

    public void AddToValue(float num)
    {
        value += num;
    }

}
