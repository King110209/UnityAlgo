using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public bool isActive = true;

    void Update()
    {
        if (isActive)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlatformStop")
        {
            direction.y = -1;
        }
        if (other.tag == "PlatformStop2")
        {
            direction.y = 1;
        }
        if (other.tag == "Player")
        {
            other.transform.SetParent(transform);
            isActive = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            print("Exit");
            isActive = false;
            other.transform.SetParent(null);
        }
    }
}
