using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public GameObject player;
    public float velocity;
    public float health;
    public float attack;
    public float vision;
    public float range;
    private float distance;
    


    void Start()
    {
        
    }

    void Update()
    {
        // distance between player and enemy
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        
        if (distance < vision)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, velocity * Time.deltaTime);
        }

        /*
        
        else if (distance < range)
        {
            // CODE ATTACK ANIMATION
        }

        */

    }
}
