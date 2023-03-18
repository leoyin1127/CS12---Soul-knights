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
    public List<Vector3> bulletPositions = new List<Vector3>();

    private GameObject bulletIns;
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

        if (bulletIns != null)
        {
            print("not null.adding..");
            bulletPositions.Add(bulletIns.transform.position);
            //print(bulletPositions.Count);
            //print("haa");
            //Debug.Log(System.String.Format("bulletPos: {0},{1},{2}", bulletPos.x, bulletPos.y, bulletPos.z));
        }
        // Remove the position of any destroyed bullets from the list
        //bulletPositions.RemoveAll(bulletPos => bulletPos == Vector3.zero);

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
