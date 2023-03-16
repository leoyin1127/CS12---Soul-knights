using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    public int damage;

    // ACCESS PLAYERSTATS
    public PlayerStats playerStats;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerStats.TakeDamage(damage);
        }
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
