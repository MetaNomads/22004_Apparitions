using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : DetachedWithinGameController
{
    private int projectileSpeed;
    private Vector3 projectileDirection;


    public void init(int speed,Vector3 direction)
    {
        this.projectileSpeed = speed;
        this.projectileDirection = direction;
    }

    void Update()
    {
        transform.position += projectileDirection * (projectileSpeed * Time.deltaTime);
    }

    private void OnHit()
    {
        //Play on hit effect
        
        //damage enemy
    }

    public void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Enemy":
                OnHit();
                break;
        }
    }
}
