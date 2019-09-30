﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControl : MonoBehaviour
{
    public AudioSource firesfx;
    public float reloadRate = 1.8f;
    public bool chamber;
    bool trigger;
    
    // Update is called once per frame
    void Update()
    {
        //Takes mouse1 input to activate trigger
        if(Input.GetButtonDown("Fire1"))
        {
            Trigger();
            
            //checks if triggger was pulled and chamber was loaded
            if((trigger == true) & (chamber == true))
            {
                //fires the gun
                Fire();
            }
        }
    }

    void Trigger()
    {
        //Trigger Boolean activating
        trigger = true;
    }
    
    void Fire()
    {
        //Fire function
        firesfx.Play();
        chamber = false;
        
        //This starts the Reload
        if(chamber == false)
        {
            StartCoroutine("Reload", reloadRate);
        }
    }
    
    IEnumerator Reload(float reloadRate)
    {
        yield return new WaitForSeconds (reloadRate);
        chamber = true;
        trigger = false;
    }
        
        // void TurretBackRecoil() {       
        //     transform.Translate(new Vector3(0,0,-50) * Time.deltaTime );         
        // }

        // void TurretForwardRecoil() {
        //     transform.Translate(new Vector3(0,0,50) * Time.deltaTime);
        // }

      
}