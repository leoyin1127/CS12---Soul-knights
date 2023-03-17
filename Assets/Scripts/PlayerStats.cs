using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 10;
    public int maxMana = 10;
    public int maxShield = 10;

    public int health;
    public int mana;
    public int shield;

    void Start()
    {
        health = maxHealth;
        mana = maxMana;
        shield = maxShield;
    }

    public void TakeDamage(int damage)
    {

        if (shield > 0)
        {
            shield -= damage;
        }

        else
        {
            health -= damage;

            if (health <=0 )
            {
                Destroy(gameObject);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
