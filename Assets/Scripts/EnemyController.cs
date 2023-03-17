using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject Player;
    public float Velocity;
    public float Health;
    public float Attack;
    public float Vision;
    private float Distance;
    

    void Update()
    {
        // distance between player and enemy
        Distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 Direction = Player.transform.position - transform.position;

        
        if (Distance < Vision)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, Velocity * Time.deltaTime);
        }

    }
}
