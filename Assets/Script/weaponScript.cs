using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponScript : MonoBehaviour
{
    public int TotalWeapons = 1;
    public int CurrentWeaponIndex;
    
    public GameObject[] Guns;
    public GameObject WeaponHolder;
    public GameObject CurrentGun;


    // Start is called before the first frame update
    void Start() 
    {
        TotalWeapons = WeaponHolder.transform.childCount;
        Guns = new GameObject[TotalWeapons];
        
        for (int i = 0; i < TotalWeapons; i++)
        {
            Guns[i] = WeaponHolder.transform.GetChild(i).gameObject;
            Guns[i].SetActive(false); 
        }

        Guns[0].SetActive(true);
        CurrentGun = Guns[0];
        CurrentWeaponIndex = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (CurrentWeaponIndex < TotalWeapons - 1)
            {
                Guns[CurrentWeaponIndex].SetActive(false);
                CurrentWeaponIndex += 1;
                Guns[CurrentWeaponIndex].SetActive(true);
                CurrentGun = Guns[CurrentWeaponIndex];
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (CurrentWeaponIndex > 0)
            {
                Guns[CurrentWeaponIndex].SetActive(false);
                CurrentWeaponIndex -= 1;
                Guns[CurrentWeaponIndex].SetActive(true);
                CurrentGun = Guns[CurrentWeaponIndex];

            }
        }
    }
}
