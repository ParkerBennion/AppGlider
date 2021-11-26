using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Instruments : MonoBehaviour
{
    public Text speed;
    public Text HoroDegrees;
    public Text VertDegrees;
    public GameObject staller;
    public Slider rightTrigger;
    public Slider leftTrigger;

    private void Start()
    {
        StartCoroutine(Warnings());
    }
    
    void Update()
    {
        speed.text = Glide.currentSpeed.ToString("MPH"+".0");
        VertDegrees.text = vQuatFinder.verticalGoldenAngle.ToString(".0" + "  PITCH");
        HoroDegrees.text = Mathf.Abs(hQuatFinder.horozontalGoldenAngle).ToString("0" + "  ROLL");

        Glide.rolllefts = leftTrigger.value;
        Glide.rollrights = rightTrigger.value;
    }


    IEnumerator Warnings()
    {
        while (Glide.isPlaying)
        {
            staller.SetActive(Glide.currentSpeed <= 11);
            yield return staller;
        }
    }
}