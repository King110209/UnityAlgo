using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
 	public float jump_force = 4.0f;
	public Rigidbody body;
	public Jump jumpscript;
    // Start is called before the first frame update
    void Start()
    {
       // jumpscript.jumpStrength += jump_force;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnTriggerEnter(Collider other)
    {
	 jumpscript.jumpStrength += jump_force;
	 body.AddForce(Vector3.up * 100 * jumpscript.jumpStrength);
    }

    void OnTriggerStay(Collider other)
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        jumpscript.jumpStrength -= jump_force;

    }

}
