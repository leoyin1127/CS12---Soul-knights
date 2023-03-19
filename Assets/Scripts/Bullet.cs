using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float Speed = 20f;
    public int Damage = 40;
    public Rigidbody2D RigidBody;
    public Vector3 bulletPos;

    // Use this for initialization
    void Start()
    {
        RigidBody.velocity = transform.right * Speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(Damage);
        }
        Destroy(gameObject);

    }


    public void Update()
    {
        Vector3 bulletPos = gameObject.transform.position;
        //Debug.Log(System.String.Format("bulletPos: {0},{1},{2}",bulletPos.x, bulletPos.y, bulletPos.z));
    }

}