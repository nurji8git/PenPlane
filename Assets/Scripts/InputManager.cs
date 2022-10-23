using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public float throttle;
    public float steer;
    public Slider slider1;
    public Slider slider2;

    private void FixedUpdate()
    {
        throttle = Input.GetAxis("Vertical");
        steer = Input.GetAxis("Horizontal");
    }

    public void MoveCar()
    {
        //throttle = slider1.value;
    }

    public void TurnWheel()
    {
        //steer = slider2.value;
    }
}
