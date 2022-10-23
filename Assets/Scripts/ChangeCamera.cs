using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public static int cam = 3;
    public GameObject[] cameras = new GameObject[cam];

    private void Start()
    {
        cameras[0].SetActive(true);
        cameras[1].SetActive(false);
        cameras[2].SetActive(false);
    }

    public void Change_Camera()
    {
        GameObject tempCam = cameras[0];
        cameras[0].SetActive(false);
        cameras[1].SetActive(true);
        cameras[2].SetActive(false);
        cameras[0] = cameras[1];
        cameras[1] = cameras[2];
        cameras[2] = tempCam;
    }
}
