using UnityEngine;
using Slider = UnityEngine.UI.Slider;

public class SliderUpdate : MonoBehaviour
{
    public Slider thrust;
    public Slider acceleration;
    public Slider topSpeed;
    public Slider turning;
    public Slider lightness;

    public Slider boost;
    
    public SO_PlaneStats ModStats;

    public void Start()
    {
        thrust.value = ModStats.thrust;
        acceleration.value = ModStats.soEngineDelta;
        topSpeed.value = ModStats.soEngineTarget;
        turning.value = ModStats.soTurning;
        lightness.value = ModStats.soGrav;
    }

    public void RefreshStats()
    {
        thrust.value = ModStats.thrust;
        acceleration.value = ModStats.soEngineDelta;
        topSpeed.value = ModStats.soEngineTarget;
        turning.value = ModStats.soTurning;
        lightness.value = ModStats.soGrav;
    }
}
