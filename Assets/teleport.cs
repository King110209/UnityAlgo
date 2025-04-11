using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
	public Vector3 targetPosition;
	public Transform a;
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = a.position;
    }

	void OnTriggerEnter(Collider other)
    {
        print("fast enough");
	 other.gameObject.transform.position = targetPosition;
    }

}
