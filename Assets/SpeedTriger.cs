using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTriger : MonoBehaviour
{
    public float speedFactor = 1.5f;

    void OnTriggerEnter(Collider other)
    {
        //other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    void OnTriggerStay(Collider other)
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        //other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
