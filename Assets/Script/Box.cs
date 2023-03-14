using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    
    public int Bullet_collision = 0;

    //count # of collisions

    void OnTriggerEnter2D(Collider2D hit)
    {
        Bullet bullet = hit.GetComponent<Bullet>();

        Bullet_collision++;
        //Debug.Log(System.String.Format("Collision time:{0}",Bullet_collision));

        if (Bullet_collision >= 3)
        {
            Destroy(gameObject);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
