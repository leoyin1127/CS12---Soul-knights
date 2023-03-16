using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Transform Gun; // add a public Transform field for the Gun object
    public GameObject Bullet;
    public float BulletSpeed;
    public float FireRate;
    public float ReadyForNextShot;
    public Transform ShootPoint;
    Vector2 direction;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousepos - (Vector2)Gun.position;
        FaceMouse();

        if (Input.GetMouseButton(0))
        {
            if (Time.time > ReadyForNextShot)
            {
                ReadyForNextShot = Time.time + 1 / FireRate;
                Shoot();
            }
        }
    }

    void Shoot()
    {
        GameObject BulletIns = Instantiate(Bullet, ShootPoint.position, ShootPoint.rotation);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * BulletSpeed);
        Destroy(BulletIns, 3);
    }

    void FaceMouse()
    {
        Gun.transform.right = direction;
    }
}
