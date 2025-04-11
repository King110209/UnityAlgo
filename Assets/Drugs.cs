using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drugs : MonoBehaviour
{
    public int healthRestored = 1;
    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.RestoreHealth(healthRestored);
        print("Yummy");
    }
}
