using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float Speed = 4.5f;


    void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
    }

    void OnCollisionEnter2d(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
