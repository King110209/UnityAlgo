using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tempature : MonoBehaviour
{
    public Player hp;
    public int damage = 2;
    public float tempatureCurrent = 36.6f;
    public float tempatureNormal = 36.6f;
    public float tempatureCritical = 34f;
    public float freezeSpeed = 0.05f;
    public float freezeDamageTimer = 1;
    public float freezeDamageDelay = 2;

    void Update()
    {
        tempatureCurrent -= freezeSpeed * Time.deltaTime;

        if(tempatureCurrent <= tempatureCritical)
        {
            if(freezeDamageTimer <= 0)
            {
                hp.TakeDamage(damage);
                freezeDamageTimer += freezeDamageDelay;   
            }
            else
            {
                freezeDamageTimer -= Time.deltaTime;
            }
        }
    }
}
