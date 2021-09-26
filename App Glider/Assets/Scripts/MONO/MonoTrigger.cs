using UnityEngine;
using UnityEngine.Events;

public class MonoTrigger : MonoBehaviour
{
    public UnityEvent triggerVolume;

    public void OnTriggerEnter(Collider other)
    {
        triggerVolume.Invoke();
    }
    //calls functoin (Declared in Editor through unity event) on trigger overlap.
}
