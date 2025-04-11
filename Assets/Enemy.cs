using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int damage = 2;
    public Transform playerPosition;
    private int MoveSpeed = 3;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition.position, MoveSpeed * Time.deltaTime);
        transform.LookAt(playerPosition.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(damage);
        print("AAAAAAAAAAA");
    }
}
