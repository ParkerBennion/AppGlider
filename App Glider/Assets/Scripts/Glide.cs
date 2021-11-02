using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Glide : MonoBehaviour
{
   // deleted player condrolls!!!!!
    
    private Rigidbody gliderBody;
    
    public static Vector3 currentAngle;
    public static Vector3 craftPos;

    public static Quaternion craftRot;

    public GameObject vertSensor;
    public GameObject horoSensor;

    public SO_PlaneStats CurrentStatus;
    
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
    public static float engineDeltaTotal;
    private static float engineTarget = 15;
    
    public static float engineTargetTotal;
    
    public static float thrustTotal;
    
    public static float engingeTargetMod;
    public static float thrustMod;
    public static float engineDeltaMod;
    
    public static bool isPlaying;
    private bool isFindingMomentum;
    public static bool engineOn;
    private static bool activeAirplane;
    public float Turning = 2;

    public Button goButton;
    
    // bool variables
    
    public static string gear = "none";

    private void Awake()
    {
        gliderBody = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().drag = .7f;
        GetComponent<Rigidbody>().angularDrag = 1;
        
        currentBoost = 0;
        
        isPlaying = true;
        
        engineOn = true;
        activeAirplane = false;
        isFindingMomentum = true;
        
        enginePower = 0;
        thrustMod = CurrentStatus.thrust;
        engingeTargetMod = CurrentStatus.soEngineTarget;
        engineDeltaMod = CurrentStatus.soEngineDelta;
        momentum = 0;
    }
    
    
    private void Start()
    {
        StartCoroutine(FindVelocity());
        
        StartCoroutine(FindMomentum());
        
        vertSensor.SetActive(true);
        horoSensor.SetActive(true);
        
        Boost();
        Modifier();
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
        // this is not in coroutine as it should run when engine is off.
    }
    
    
    private void Update()
    {
        gravAngle = Mathf.Abs(vQuatFinder.verticalGoldenAngle * .08f);
        rotAngle = hQuatFinder.horozontalGoldenAngle * .2f;
        
        //adds gravity to the craft at high angles.
        var transform1 = transform;
        currentAngle = transform1.eulerAngles;
        
        craftPos = transform1.position;
        craftRot = transform1.rotation;
        // used as reference in other scripts that need the orientation of the player.
        
        momentum = AccelTester.currStrength*-1;
        //Does this need to be in update or can it be multiplied by -1 in the momentum script?
    }


    public static void Modifier()
    {
        thrustTotal = thrustMod;
        engineTargetTotal = engineTarget + engingeTargetMod;
        engineDeltaTotal = engineDelta + engineDeltaMod;
    }
    //runs this equation to get the value of the thrust plus and buff or debuffs form the modifier.
    
    
    
    //  control over the flying state. this can be made into template for other gliders. also needs variables for ease of changing the numbers in case of status effects.
    public static void Boost()
    {
        boostMode = currentBoost;
        switch (boostMode)
        {
            case 0 :
                engineTarget = 0;
                activeAirplane = false;
                engineOn = true;
                gear = "OFF";
                Modifier();
                Debug.Log("switch run enginge off");
                break;

            case 1 :
                Modifier();
                engineTarget = 15;
                engineOn = true;
                gear = "ON";
                Modifier();
                Debug.Log("switch run enginge ON!!!!!!");
                break;
        }
    }
    //this could be set to a bool but is kept as a switch for ease of changing states later if i want



    IEnumerator FindVelocity()
    {
        
        while (isPlaying)
        {
            Vector3 prevPos = transform.position;
            yield return new WaitForFixedUpdate();
            currentSpeed = Mathf.RoundToInt(Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime);
        }
    }
    //finds the velocity of the player
    //DO NOT TURN OFF IS PLAYING WHILE BEING USED
    //github.com/anthony romerell 2021 classs repository for SO references. 

    IEnumerator FindMomentum()
    {
        while (isFindingMomentum)
        {
            enginePower = Mathf.MoveTowards(enginePower, engineTargetTotal, engineDeltaTotal * Time.deltaTime);

            momentumApplied = Mathf.MoveTowards(momentumApplied, AccelTester.maxStrength*-1,
                Mathf.Abs(momentum/2) * Time.deltaTime);

            power = enginePower + momentumApplied;

            if (power < 0)
            {
                power = 0;
            }

            yield return power;
        }
        //ENGINE POWER, ENGINE TARGET, ENGINE DELTA, MOMENTUM APPLIED, IS FINDING MOMENTUM.
        // total , max speed , acceleration (up and down), gravity adding speed.
    }

    private IEnumerator AirplaneActive()
    {
        while (activeAirplane)
        {
            Transform transform1;
            (transform1 = transform).Translate(Vector3.forward * (power * Time.deltaTime));// rail like movement
            gliderBody.AddForce(transform1.forward * (thrustTotal * Time.deltaTime)); // vector type movement

            transform.Rotate(Time.deltaTime * 100 * Vector3.right);//constant dive

            transform.Rotate(Vector3.left * (rolllefts * 100 * Time.deltaTime));// pitch right
            transform.Rotate(Vector3.back * (rolllefts * 70 * Time.deltaTime)); // lift
        
            transform.Rotate(Vector3.left * (rollrights * 100 * Time.deltaTime)); //pitch left
            transform.Rotate(Vector3.forward * (rollrights * 70 * Time.deltaTime)); //lift

            transform.Rotate(Vector3.up * (rotAngle* Turning * Time.deltaTime)); //rotate (Yaw)

            yield return new WaitForFixedUpdate();
        }
        //ACTIVE AIRPLANE
        // how agile the plane is and yaw control depending on pitch
    }

    public void StartAirplaneActive()
    {
        currentBoost = 1;
        activeAirplane = true;
        StartCoroutine(AirplaneActive());
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
    
}
