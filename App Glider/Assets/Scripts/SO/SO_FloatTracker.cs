using UnityEngine;

[CreateAssetMenu]
public class SO_FloatTracker : ScriptableObject
{
    public int nextPoint;

    public void Checkpoint(int pointNum)
    {
        nextPoint += pointNum;
    }

}
