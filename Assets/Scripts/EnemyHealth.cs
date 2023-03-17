using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int Health;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
