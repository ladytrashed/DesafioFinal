using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maseta : MonoBehaviour
{
    private Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        //myRigidbody.AddForce(Vector3.forward);
        myRigidbody.AddForce(Vector3.forward * 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
