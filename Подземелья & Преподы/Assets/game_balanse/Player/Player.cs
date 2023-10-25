using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;

public class Player : parametor
{
  
    [SerializeField] private float shootInterval;
    [SerializeField] private GameObject bull;
    [SerializeField] private float shotSpeed;
    [SerializeField] private boot[] boot_List;
    private float shotTime;
    void Update()
    {
        Move();
        shoot();
    }
   private void Move()
    {
       float gor = Input.GetAxis("Horizontal");
       float  ver = Input.GetAxis("Vertical");
       Vector3  step = new Vector3(gor, ver,0);
        transform.position += step * moveSpeed * Time.deltaTime;
    }
    private void shoot()
    {
        shotTime += Time.deltaTime;
        if (shotTime >= shootInterval)
        {
            shotTime = 0;
            GameObject bullet = Instantiate(bull, transform.position, Quaternion.identity);
            Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
            boot closet = Findboot();
            Vector3 bistans =(closet.transform.position-transform.position).normalized;
            rigidbody.AddForce(bistans*shotSpeed);
        }
    }
    boot Findboot()
    {
        boot clos = null;
        float minboot = float.MaxValue;
        foreach (var boot in boot_List)
        {
            float bist = (boot.transform.position - transform.position).magnitude;
            if (minboot > bist)
            {
                clos = boot;
                minboot = bist;
            }
        }
        return clos;

    }
}
