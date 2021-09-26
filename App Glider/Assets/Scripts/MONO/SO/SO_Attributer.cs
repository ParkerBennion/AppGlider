using UnityEngine;

[CreateAssetMenu]
public class SO_Attributer : ScriptableObject
{
    public bool active;
    public int strength;
    public GameObject looks;
    public ParticleSystem emission;
    //this type of SO is used to hold variables an nothing more. other scripts can reference it to get info
    //EXAMPLE: after a player dies this script is reverenced to see that default items they could spawn with.
}
