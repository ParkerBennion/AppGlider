using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public int pauseValue;
    public void pause()
    {
        Time.timeScale = pauseValue;
    }

    public void togglePause()
    {
        if (pauseValue > 0)
        {
            pauseValue--;
            pause();
        }
        else
        {
            pauseValue++;
            pause();
        }
    }
}
