using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUps : MonoBehaviour
{

    private string buffs;
    private bool speedPowerUp, accelerationPowerUp, thrustPowerUp;

    private void Awake()
    {
        speedPowerUp = true;
        accelerationPowerUp = true;
        thrustPowerUp = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            buffs = "Speed";
        }
        else if (other.CompareTag("MainCamera"))
        {
            buffs = "Acceleration";
        }
        else if (other.CompareTag("EditorOnly"))
        {
            buffs = "Thrust";
        }
        // ^^ change these tags to make sense
        switch (buffs)
        {
            case "Speed":
                if (speedPowerUp)
                {
                    Debug.Log(other.tag);
                    Glide.engingeTargetMod = 40;
                    Glide.Modifier();
                    speedPowerUp = false;
                    StartCoroutine(SpeedPowerUPReset());
                }
                other.gameObject.transform.Translate(5,0,0);
                //Destroy(other.gameObject);
                break;
            
            case "Acceleration":
                if (accelerationPowerUp)
                {
                    Debug.Log(other.tag);
                    Glide.engineDeltaMod = 8;
                    Glide.Modifier();
                    accelerationPowerUp = false;
                    StartCoroutine(accelerationPowerUpReset());
                }
                other.gameObject.transform.Translate(0,5,0);
                //Destroy(other.gameObject);
                break;
            
            case "Thrust":
                if (thrustPowerUp)
                {
                    Debug.Log(other.tag);
                    Glide.thrustMod = 3000;
                    Glide.Modifier();
                    thrustPowerUp = false;
                    StartCoroutine(thrustPowerUpReset());
                }
                other.gameObject.transform.Translate(0,5,0);
                //Destroy(other.gameObject);
                break;
        }
        // ^^ these need to refresh and reset to default values of 0;

        IEnumerator SpeedPowerUPReset()
        {
            yield return new WaitForSeconds(5);
            speedPowerUp = true;
            Glide.engingeTargetMod = 0;
            Glide.Modifier();
            Debug.Log(other.tag  + "deactivated");
        }
        
        IEnumerator  accelerationPowerUpReset()
        {
            yield return new WaitForSeconds(5);
            accelerationPowerUp = true;
            Glide.engineDeltaMod = 0;
            Glide.Modifier();
            Debug.Log(other.tag  + "deactivated");
        }
        
        IEnumerator thrustPowerUpReset()
        {
            yield return new WaitForSeconds(5);
            thrustPowerUp = true;
            Glide.thrustMod = 0;
            Glide.Modifier();
            Debug.Log(other.tag  + "deactivated");
        }
    }
    // i hate this script. i wanted to use an enum to make this more condenced but could not find how
    // this appears sloppy to me. i also wanted to avoid another switch.
    // something similar can be used to make checkpoints
    
}
