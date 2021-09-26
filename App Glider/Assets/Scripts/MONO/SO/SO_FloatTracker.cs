using UnityEngine;

[CreateAssetMenu]
public class SO_FloatTracker : ScriptableObject
{
    public float baseNum;
    public float baseNumTwo;
    //^^dont put in a second variable (at least in public) as the below functions only are dictating
    //to use the original variable.

    public void Add(float addNum)
    {
        baseNum += addNum;
    }
    // adds base to addnum (addnum declared in editor)

    public void Multi(float multiNum)
    {
        baseNum *= multiNum;
    }
    
    
}
