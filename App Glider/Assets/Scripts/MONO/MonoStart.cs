using UnityEngine;
using UnityEngine.Events;

public class MonoStart : MonoBehaviour
{
    public UnityEvent startBehaviour;

    public void Start()
    {
        startBehaviour.Invoke();
    }
}
