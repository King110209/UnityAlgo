using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonFire : MonoBehaviour
{
    public float lifeTime = 15;
    public float heatPower = 0.1f;

    void Update()
    {
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.GetComponent<Tempature>() != null)
        {
            Tempature tempature = other.GetComponent<Tempature>();

            if(tempature.tempatureCurrent < tempature.tempatureNormal)
            {
                tempature.tempatureCurrent += heatPower * Time.deltaTime;
            }
        }
    }
}
