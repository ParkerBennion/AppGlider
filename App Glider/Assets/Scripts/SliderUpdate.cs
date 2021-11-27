using UnityEngine;
using UnityEngine.UI;
using Slider = UnityEngine.UI.Slider;

public class SliderUpdate : MonoBehaviour
{
    public Slider fuel;
    public Slider acceleration;
    public Slider topSpeed;
    public Slider turning;
    public Slider lightness;
    public Text parts;

    public Slider boost;
    
    public SO_PlaneStats ModStats;
    public SO_FloatTracker money;

    public void Start()
    {
        fuel.value = ModStats.fuel;
        acceleration.value = ModStats.soEngineDelta;
        topSpeed.value = ModStats.soEngineTarget;
        turning.value = ModStats.soTurning;
        lightness.value = ModStats.soGrav;
        parts.text = money.baseInt.ToString("");
    }

    public void RefreshStats()
    {
        fuel.value = ModStats.fuel;
        acceleration.value = ModStats.soEngineDelta;
        topSpeed.value = ModStats.soEngineTarget;
        turning.value = ModStats.soTurning;
        lightness.value = ModStats.soGrav;
        parts.text = money.baseInt.ToString("");
    }
    
}
