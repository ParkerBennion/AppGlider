using UnityEngine;

[CreateAssetMenu]
public class SO_IntCaller : ScriptableObject
{
    public float baseNum;
    public int baseInt;
    public int limitInt;

    public void Add(float addNum)
    {
        baseNum += addNum;
    }

    public void Multi(float multiNum)
    {
        baseNum *= multiNum;
    }

    public void AddInt(int addNum)
    {
        baseInt += addNum;
        if (baseInt >= limitInt)
        {
            StopTime();
        }

        if (baseInt == 0)
        {
            StartTime();
        }
    }
    
    public void StopTime()
    {
        Time.timeScale = 0f;
    }

    public void StartTime()
    {
        Time.timeScale = 1f;
    }
    

}
