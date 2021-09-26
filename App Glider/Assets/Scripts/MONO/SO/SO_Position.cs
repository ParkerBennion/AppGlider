using UnityEngine;
[CreateAssetMenu]
public class SO_Position : ScriptableObject
{
    public Vector3 location;

    public void SetPosition(Transform cord)
    {
        location = cord.position;
    }

    public void GoToPositon(Transform cord)
    {
        cord.position = location;
    }
    //gets and sets the position of the player (checkpoints and stuff)
}
