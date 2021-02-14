using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public int health = 3;
    public event Action<Player> onPlayerDeath;
    void collidedWithEnemy(Enemy enemy) {
        enemy.Attack(this);// Enemy attack code
        if(health <= 0) {
            if(onPlayerDeath != null) {
                onPlayerDeath(this);
            }
        }   
    }


    void OnCollisionEnter (Collision col) {
        Enemy enemy = col.collider.gameObject.GetComponent<Enemy>();
        if(enemy) {
            collidedWithEnemy(enemy);
        }
    }
}
