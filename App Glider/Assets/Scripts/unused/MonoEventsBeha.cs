using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBeha : MonoBehaviour
{
    public UnityEvent startEvent;
    void Start()
    {
        startEvent.Invoke();
    }
    //this creates a ui in the unity editor to do unity funcions
}
