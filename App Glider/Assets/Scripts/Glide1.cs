using System;
using System.Collections;
using UnityEngine;

public class Glide1 : MonoBehaviour
{

    private Rigidbody gliderBody;
    
    public static Vector3 currentAngle;
    public static Vector3 craftPos;

    public static Quaternion craftRot;
    
    public GameObject takeoffSprite;

    public GameObject vertSensor;
    public GameObject horoSensor;
    
    public static float power = 13;
    public static float rollrights;
    public static float rolllefts;
    public static float currentSpeed;
    public static float gravTotal;
    public static float gravAngle;
    public static float rotAngle;
    private static float grav = 13f;
    private static int boostMode;
    // do not toutch
    
    public static float enginePower;
    public static float momentum;
    public static float momentumApplied;
    public static int currentBoost;
    
    public static float engineDelta =2;
    public static float engineDeltaMod;
    public static float engineDeltaTotal;
    
    private static float engineTarget = 15;
    public static float engingeTargetMod;
    public static float engineTargetTotal;
    
    // in progress.
    public static float thrust = 0;
    public static float thrustMod = 100;
    public static float thrustTotal;
    // variables

    
    public static bool isPlaying;
    private bool isFindingMomentum;
    public static bool engineOn;
    private static bool activeAirplane;
    
    // bool variables
    
    public static string gear = "none";
    
    
    private void Awake()
    {
        gliderBody = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().drag = .7f;
        GetComponent<Rigidbody>().angularDrag = 1;
        
        currentBoost = -1;
        
        isPlaying = true;
        engineOn = false;
        activeAirplane = false;
        isFindingMomentum = true;
        
        enginePower = 0;
        momentum = 0;
    }
    
    
    private void Start()
    {
        StartCoroutine(FindVelocity());
        StartCoroutine(FindMomentum());
        //StartCoroutine(StartAccelerating());
        vertSensor.SetActive(true);
        horoSensor.SetActive(true);
        Boost();
        //sets the angle finding objects in the scene.
    }
    
    
    void FixedUpdate()
    {
        gravTotal = grav - currentSpeed + gravAngle;
        if (gravTotal < 1)
        {
            gravTotal = 0;
        }
        Physics.gravity = new Vector3(0, -gravTotal, 0);
        // adds gravity dependant on the speed of craft.
        //this variable could be described as minimum speed to fly.
    }
    
    
    private void Update()
    {
        gravAngle = Math.Abs(vQuatFinder.verticalGoldenAngle * .08f);
        rotAngle = hQuatFinder.horozontalGoldenAngle * .2f;
        
        //adds gravity to the craft at high angles.
        currentAngle = transform.eulerAngles;
        
        craftPos = transform.position;
        craftRot = transform.rotation;
        // used as reference in other scripts that need the orientation of the player.
        
        momentum = AccelTester.currStrength*-1;
        /*if (momentum > 9)
        {
            momentum = 9;
        }
        else if (momentum < -9)
        {
            momentum = -9;
        }*/
        //adds extra speed dependant on accel test numbers.
    }


    public static void Modifier()
    {
        thrustTotal = thrust + thrustMod;
        engineTargetTotal = engineTarget + engingeTargetMod;
        engineDeltaTotal = engineDelta + engineDeltaMod;
    }
    //runs this equation to get the value of the thrust plus and buff or debuffs form the modifier.
    
    
    private static void Boost()
    {
        boostMode = currentBoost;
        switch (boostMode)
        {
            case -1 :
                thrust = 0;
                engineTarget = 15;
                engineOn = false;
                gear = "OFF";
                Modifier();
                break;
            
            case 0 :
                thrust = 0;
                engineTarget = 15;
                activeAirplane = true;
                engineOn = true;
                gear = "ON";
                Modifier();
                break;
            
            case 1 :
                thrust = 600;
                engineTarget = 15;
                gear = "BOOST";
                Modifier();
                break;
            
        }
    }
    //  control over the flying state. this can be made into template for other gliders. also needs variables for ease of changing the numbers in case of status effects.



    IEnumerator FindVelocity()
    {
        
        while (isPlaying)
        {
            Vector3 prevPos = transform.position;
            yield return new WaitForFixedUpdate();
            currentSpeed = Mathf.RoundToInt(Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime);
        }
        /*var position = transform.position;
            Vector3 prevPos = position;
            yield return new WaitForFixedUpdate();
            currentSpeed = Mathf.RoundToInt(Vector3.Distance(position, prevPos) / Time.fixedDeltaTime);*/
    }
    //finds the velocity of the player
    //DO NOT TURN OFF IS PLAYING WHILE BEING USED

    IEnumerator FindMomentum()
    {
        while (isFindingMomentum)
        {
            enginePower = Mathf.MoveTowards(enginePower, engineTargetTotal, engineDeltaTotal * Time.deltaTime);

            momentumApplied = Mathf.MoveTowards(momentumApplied, AccelTester.maxStrength*-1,
                Mathf.Abs(momentum/2) * Time.deltaTime);
            
            
            /*enginePower = (engineOn) ? Mathf.MoveTowards(enginePower, 15, engineDelta * Time.deltaTime) 
                : enginePower = Mathf.MoveTowards(enginePower, 15, -.2f * Time.deltaTime);*/
            
            if (enginePower<0)
            {
                enginePower = 0;
            }

            power = enginePower + momentumApplied;

            if (power < 0)
            {
                power = 0;
            }
            // is this ^^^ inefficient
            yield return power;
        }
        //ENGINE POWER, ENGINE TARGET, ENGINE DELTA, MOMENTUM APPLIED, IS FINDING MOMENTUM.
        // total , max speed , acceleration (up and down), gravity adding speed.
    }

    private IEnumerator AirplaneActive()
    {
        while (activeAirplane)
        {
            transform.Translate(Vector3.forward * (power * Time.deltaTime));// rail like movement
            gliderBody.AddForce(transform.forward * (thrustTotal * Time.deltaTime)); // vector type movement

            transform.Rotate(Time.deltaTime * 100 * Vector3.right);//constant dive

            transform.Rotate(Vector3.left * (rollrights * 100 * Time.deltaTime));// pitch right
            transform.Rotate(Vector3.back * (rollrights * 70 * Time.deltaTime)); // lift
        
            transform.Rotate(Vector3.left * (rolllefts * 100 * Time.deltaTime)); //pitch left
            transform.Rotate(Vector3.forward * (rolllefts * 70 * Time.deltaTime)); //lift

            transform.Rotate(Vector3.up * (rotAngle * Time.deltaTime)); //rotate (Yaw)

            yield return new WaitForFixedUpdate();
        }
        //ACTIVE AIRPLANE
        // how agile the plane is and yaw control depending on pitch
        
    }


    /*IEnumerator FullReset()
    {
        yield return new WaitForFixedUpdate();
        activeAirplane = false;
        engineOn = false;
        engineTarget = 0;
        engineDelta = 2;
        currentBoost = -1;
        StopCoroutine(AirplaneActive());
    }*/
    // this is the default state of the variables. need to make these variables fixed.
    
    
    void BoostUp()
    {
        if (!activeAirplane && rollrights  >= .4f)
        {
            activeAirplane = true;
            engineOn = true;
            currentBoost = 0;
            StartCoroutine(AirplaneActive());
            Boost();
            
        }
        else if (currentBoost<1 && activeAirplane)
        {
            currentBoost++;
        }
        else
        {
            return; // play audio here
        }
    }
    // switches between motor functions. delays and animations would be cool to add to these
    
    
    void BoostActivate()
    {
        Boost();
    }
    // switches modes in the boost method.
    
    
    void BoostDown()
    {
        if (currentBoost>-1)
        {
            currentBoost--; 
        }
    }
    void BoostDownActivate()
    {
        Boost(); 
    }
}
