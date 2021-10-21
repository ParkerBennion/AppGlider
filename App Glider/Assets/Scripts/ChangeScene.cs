using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public SO_FloatTracker currentsceneHere;
    
    public void ChangeSceneFunction()
    {
        SceneManager.LoadScene(currentsceneHere.baseInt);
    }
    
}
