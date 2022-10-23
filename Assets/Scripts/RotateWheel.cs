using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : MonoBehaviour
{
    public GameObject[] wheels = new GameObject[4];
    CarController carCon;
    InputManager im;
    float wheel_degree = 0.0f;
    private void Start()
    {
        im = GetComponent<InputManager>();
        carCon = GetComponent<CarController>();
    }

    private void FixedUpdate()
    {
        if (wheel_degree >= 360.0f || wheel_degree <= -360.0f)
            wheel_degree = 0.0f;

        wheel_degree = Time.deltaTime * im.throttle * 1000.0f;
        wheels[0].transform.localEulerAngles = new Vector3(0.0f, carCon.maxTurn * im.steer - 90f, wheels[0].transform.localEulerAngles.z);
        wheels[1].transform.localEulerAngles = new Vector3(0.0f, carCon.maxTurn * im.steer + 90f, wheels[1].transform.localEulerAngles.z);

        wheels[0].transform.localEulerAngles += new Vector3(0.0f, 0.0f, -wheel_degree);
        wheels[1].transform.localEulerAngles += new Vector3(0.0f, 0.0f, wheel_degree);
        wheels[2].transform.localEulerAngles += new Vector3(0.0f, 0.0f, wheel_degree);
        wheels[3].transform.localEulerAngles += new Vector3(0.0f, 0.0f, -wheel_degree);
    }
}
