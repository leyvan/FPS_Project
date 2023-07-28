using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject gunBarrel;

    [SerializeField] private float fireRate = 0.1f;

    private int clipSize = 20;
    private float timeToFire;

    private void FireBullet()
    {
        var newBullet = Instantiate(bullet, gunBarrel.transform.position + new Vector3(0, 0, 0.5f), gunBarrel.transform.rotation);
        timeToFire = 0;
    }
    
    private void Update()
    {
        timeToFire += Time.deltaTime;

        if (timeToFire < fireRate) return;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FireBullet();
        }
    }

}
