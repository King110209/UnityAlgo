using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int coin = 0;
    public int hp = 10;
    public int max_hp = 10;
    
   public void CollectCoins(){
        print("a");
        coin++;
        print("Collected Coins" + coin);
    }

    public void TakeDamage(int damage)
    {
        if(hp > 0)
        {
            hp -= damage;
            print("Players health: " + hp);
        }
        else
        {
            print("Noob");
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

    public void RestoreHealth(int healthRestored){
        hp += healthRestored;
        if(hp > 10){
            hp = 10;
        }
    }
}
