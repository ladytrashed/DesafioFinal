using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject[] cameras;
    int activeCamera;
    // Start is called before the first frame update
    void Start()
    {
        ChangeCamera(cameras.Length - 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            ChangeCamera(activeCamera);
        }
    }
    void ChangeCamera(int camera)
    {
        activeCamera = (camera + 1) % cameras.Length;
        for (int F1 = 0; F1 < cameras.Length; F1++)
        {
            if (F1 == activeCamera)
            {
                cameras[F1].SetActive(true);
            }
            else
            {
                cameras[F1].SetActive(false);
            }
        }
    }
}
