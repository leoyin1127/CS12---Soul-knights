using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Transform Gun;
    public GameObject Bullet;
    public float BulletSpeed;
    public float FireRate;
    public float ReadyForNextShot;
    public Transform ShootPoint;
    public Vector3 bulletPos;
    Vector2 direction;

    private GameObject bulletIns;


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

        if (bulletIns != null)
        {
            Vector3 bulletPos = bulletIns.transform.position;
            Debug.Log(System.String.Format("bulletPos: {0},{1},{2}", bulletPos.x, bulletPos.y, bulletPos.z));
        }
    }

    void Shoot()
    {
        bulletIns = Instantiate(Bullet, ShootPoint.position, ShootPoint.rotation);
        bulletIns.GetComponent<Rigidbody2D>().AddForce(bulletIns.transform.right * BulletSpeed);
        Destroy(bulletIns, 3);
    }


    void FaceMouse()
    {
        Gun.transform.right = direction;
    }

   
}
