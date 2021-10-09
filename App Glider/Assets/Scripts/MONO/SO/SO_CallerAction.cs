using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class SO_CallerAction : ScriptableObject
{
    public UnityAction callOut;

    public void CallAction()
    {
        callOut.Invoke();
    }
}
