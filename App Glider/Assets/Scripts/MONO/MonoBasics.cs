using System;
using UnityEngine.Events;
using UnityEngine;

public class MonoBasics : MonoBehaviour
{
    public UnityEvent startBehaviour, awakeBehaviour, runBehaviour, disableBehaviour, destroyBehaviour, quitBehaviour;


    public void Awake()
    {
        awakeBehaviour.Invoke();
    }

    public void Start()
    {
        startBehaviour.Invoke();
    }

    public void Run()
    {
        runBehaviour.Invoke();
    }

    public void OnDisable()
    {
        disableBehaviour.Invoke();
    }

    public void OnDestroy()
    {
        destroyBehaviour.Invoke();
    }

    public void OnApplicationQuit()
    {
        quitBehaviour.Invoke();
    }
}
