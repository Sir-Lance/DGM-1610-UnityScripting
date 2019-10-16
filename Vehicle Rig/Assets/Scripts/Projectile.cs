﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    public GameObject impactEffect;

    void OnTriggerEnter(Collider other)
    {
         float posX = transform.position.x;
         float posY = transform.position.y;
         float posZ = transform.position.z;
         
         Vector3 newPos = new Vector3(posX, posY, posZ);
         GameObject impactFX = Instantiate(impactEffect, newPos, Quaternion.LookRotation(newPos));
         Destroy(gameObject, 0.1f);
         

    }
}
