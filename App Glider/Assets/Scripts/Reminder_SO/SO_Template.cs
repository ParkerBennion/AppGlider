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
