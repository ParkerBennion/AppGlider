
using UnityEngine;
using UnityEngine.Events;

public class GameActnHandler : MonoBehaviour
{
    public SO_CallerAction callactionObj;
    public UnityEvent handleEvent;
    public void Start()
    {
        callactionObj.callOut += Handle;
    }

    private void Handle()
    {
        handleEvent.Invoke();
    }
}
