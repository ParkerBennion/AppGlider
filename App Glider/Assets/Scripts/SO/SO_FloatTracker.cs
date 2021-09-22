using UnityEngine;

[CreateAssetMenu]
public class SO_FloatTracker : ScriptableObject
{
    public int nextPoint;

    void Checkpoint(int pointNum)
    {
        nextPoint += pointNum;
    }

}
