using UnityEngine;

[CreateAssetMenu]
public class SO_Template : ScriptableObject
{
    public float value;
    
    void AddToValue(float num)
    {
        value += num;
    }
}
